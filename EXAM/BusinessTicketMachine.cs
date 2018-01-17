using System;
using System.Collections.Generic;
using System.IO;
using static EXAM.ExceptionClass;

namespace EXAM {
    public class BusinessTicketMachine : ITicketMachine{
        private Dictionary<string, string> CityCodes = new Dictionary<string, string>();
        private List<Ticket> SoldTickets = new List<Ticket>();
        internal DateTime _departureTime;
        private string _origin, _destination;
        private double _price;
        internal int _nrOfSeats;
        internal int _ticketType = 1, _priceMultiplier = 2;
        private bool _businessAvailable, _flightCodeInvalid;
        private const string SOLD_TICKETS_PATH = "sold_tickets.txt";
        private const int DAYS_IN_MONTH = 30;

        public BusinessTicketMachine(string flightCode, string departureTime) {
            AddCitiesToDictionary();
            GetFlightCode(flightCode);
            _departureTime = ValidDate(departureTime);
            Console.WriteLine("Ticket selling machine set with departure time: {0}",
                _departureTime.ToShortDateString());
        }

        private void AddCitiesToDictionary() {
            CityCodes.Add("TYO", "Tokyo");
            CityCodes.Add("TLL", "Tallinn");
            CityCodes.Add("BER", "Berlin");
            CityCodes.Add("KBP", "Kiev");
            CityCodes.Add("KRS", "Kuressaare");
        }

        private void GetFlightCode(string flightCode) {
            if (flightCode.Length == 9 || flightCode.Length == 10) {
                flightCode = ReturnFlightCodeInCaps(flightCode);
                
                string cityA = flightCode.Substring(2, 3);
                CheckCityCodeInFlightCode(cityA);

                string cityB = flightCode.Substring(5, 3);
                CheckCityCodeInFlightCode(cityB);
                
                string direction = flightCode.Substring(8, 1);
                switch (int.Parse(direction)) {
                    case 2:
                        _origin = CityCodes[cityA];
                        _destination = CityCodes[cityB];
                        break;
                    case 5:
                        _origin = CityCodes[cityB];
                        _destination = CityCodes[cityA];
                        break;
                    default:
                        _flightCodeInvalid = true;
                        throw new InvalidFlightCodeException(direction);
                }
                
                if (flightCode.Length == 10) {
                    string flightClass = flightCode.Substring(9, 1);
                    switch (flightClass) {
                        case "b":
                            _businessAvailable = true;
                            break;
                        default:
                            _flightCodeInvalid = true;
                            throw new InvalidFlightCodeException(flightClass);
                    }
                }
                
                Console.WriteLine("Ticket selling machine set with flight code: {0}", flightCode);
            } else {
                _flightCodeInvalid = true;
                throw new InvalidFlightCodeException($"Invalid length: {flightCode.Length}. Must be 9 or 10.");
            }
        }

        private DateTime ValidDate(string date) {
            try {
                DateTime validDate = DateTime.Parse(date);
                return validDate;
            } catch (Exception e) {
                Console.WriteLine(e);
                return new DateTime();
            }
        }

        private string ReturnFlightCodeInCaps(string flightCode) {
            string flightCodeInCaps = "";
            for (int i = 0; i < 7; i++) {
                flightCodeInCaps += char.ToUpper(flightCode[i]);
            }

            for (int i = 7; i < flightCode.Length; i++) {
                flightCodeInCaps += flightCode[i];
            }

            return flightCodeInCaps;
        }
        
        private void CheckCityCodeInFlightCode(string cityCode) {
            if (!CityCodes.ContainsKey(cityCode)) {
                throw new InvalidFlightCodeException(cityCode);
            }
        }
        
        public virtual void SetPriceAndSeats(double price, int nrOfSeats) {
            if (price > 0) {
                _price = price;
            } else {
                throw new NegativeOrZeroException("EUR", price);
            }

            if (nrOfSeats > 0) {
                _nrOfSeats = nrOfSeats;
            } else {
                throw new NegativeOrZeroException(nrOfSeats);
            }
        }

        public void PrintTicketInfo() {
            if (SoldTickets.Count > 0) {
                for (int i = 0; i < SoldTickets.Count; i++) {
                    Console.WriteLine("TICKET {0}:", i + 1);
                    Console.WriteLine(SoldTickets[i].ReturnInfo());
                }
            } else {
                throw new NoTicketsSoldException();
            }
        }

        public void SaveTicketInfo() {
            if (SoldTickets.Count > 0) {
                using (StreamWriter writer = new StreamWriter(SOLD_TICKETS_PATH, false)) {
                    for (int i = 0; i < SoldTickets.Count; i++) {
                        writer.WriteLine("TICKET {0}:", i + 1);
                        writer.WriteLine(SoldTickets[i].ReturnInfo());
                    }
                }
            } else {
                throw new NoTicketsSoldException();
            }
        }

        public void PrintNrOfFreeSeats() {
            int nrOfFreeSeats = _nrOfSeats - SoldTickets.Count;
            Console.WriteLine("Free seats: {0}", nrOfFreeSeats);
        }

        public void SellTicket(string name) {
            DateTime buyingDate = DateTime.Now;
            
            SellTicket(name, buyingDate.ToShortDateString());
        }

        public void SellTicket(string name, string buyingTime) {
            DateTime buyingDate = ValidDate(buyingTime);

            if (CanSellTicket()) {
                if (SoldTickets.Count < _nrOfSeats) {
                    if (buyingDate <= _departureTime) {
                        Ticket ticket = CreateTicket(name, buyingDate);

                        SoldTickets.Add(ticket);
                        Console.WriteLine(ticket.ReturnInfo());
                    } else {
                        throw new BuyingTimeInFutureException();
                    }
                } else {
                    Console.WriteLine("Tickets are sold out!");
                }
            }
        }

        internal virtual bool CanSellTicket() {
            if (_businessAvailable) {
                return true;
            }

            throw new BusinessClassNotAvailableException();
        }
        
        private Ticket CreateTicket(string name, DateTime buyingTime) {
            Ticket ticket = new Ticket();
            
            ticket.PassengerName = name;
            ticket.FlightDate = _departureTime;
            ticket.Origin = _origin;
            ticket.Destination = _destination;
            ticket.SeatNr = SoldTickets.Count + 1;
            ticket.TicketType = _ticketType;
            ticket.Price = CalculateTicketPrice(buyingTime);

            return ticket;
        }
        
        internal virtual double CalculateTicketPrice(DateTime buyingTime) {
            double price = _price;

            TimeSpan span = _departureTime - buyingTime;
            double monthMultiplier = Math.Round((double)(span.Days / DAYS_IN_MONTH), 2);
            
            if (monthMultiplier < 6) {
                price += price * (6 - monthMultiplier) * 0.1;
            }

            double occupancyRate = (SoldTickets.Count / _nrOfSeats) * 100;

            if (occupancyRate >= 26 && occupancyRate <= 50) {
                price += price * 0.1 * _priceMultiplier;
            } else if (occupancyRate >= 51 && occupancyRate <= 75) {
                price += price * 0.13 * _priceMultiplier;
            } else if (occupancyRate >= 76 && occupancyRate <= 100) {
                price += price * 0.17 * _priceMultiplier;
            }

            if (_ticketType == 1) {
                double refundable = price * 1.2;

                Console.Write("Your business class ticket price is {0} EUR. Would you like to buy a refundable " +
                              "ticket instead? It would cost {1} EUR. Y/N", price, refundable);
                string answer = Console.ReadLine();
                if (answer == "Y" || answer == "y") {
                    price = refundable;
                }
            }

            return price;
        }

        public void DisplayHighLowAveragePrices() { //TODO
            if (SoldTickets.Count >= 5) {
                double highestPriceOne = 0;
                double highestPriceTwo = 0;
                double lowestPriceOne = SoldTickets[0].Price;
                double lowestPriceTwo = SoldTickets[1].Price;
                double avgPrice = 0;
                
                foreach (Ticket ticket in SoldTickets) {
                    avgPrice += ticket.Price;
                }

                avgPrice = avgPrice / SoldTickets.Count;
            } else if (SoldTickets.Count < 5 && SoldTickets.Count >= 3) {
                double highestPrice = 0;
                double lowestPrice = SoldTickets[0].Price;

                foreach (Ticket ticket in SoldTickets) {
                    if (ticket.Price > highestPrice) {
                        highestPrice = ticket.Price;
                    }

                    if (ticket.Price < lowestPrice) {
                        lowestPrice = ticket.Price;
                    }
                }
            } else if (SoldTickets.Count < 3) {
                Console.WriteLine("Too few tickets!");
            }
        }
    }
}