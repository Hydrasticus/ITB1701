using System;
using System.Collections.Generic;
using System.IO;
using static EXAM.ExceptionClass;

namespace EXAM {
    public class BusinessTicketMachine : ITicketMachine{
        private readonly Dictionary<string, string> CityCodes = new Dictionary<string, string>();
        private readonly List<Ticket> SoldTickets = new List<Ticket>();
        private DateTime _departureTime;
        private string _origin, _destination;
        private const string SOLD_TICKETS_PATH = "sold_tickets.txt";
        private double _initialPrice;
        private int _nrOfSeats;
        private bool _businessAvailable, _flightCodeInvalid; //TODO: find workaround for _flightCodeInvalid

        public void TicketMachine(string flightCode, string departureTime) {
            AddCitiesToDictionary();
            GetFlightCode(flightCode);
            _departureTime = ReturnDepartureTime(departureTime);
        }

        private void AddCitiesToDictionary() {
            CityCodes.Add("TLL", "Tallinn");
            CityCodes.Add("TYO", "Tokyo");
            CityCodes.Add("BER", "Berlin");
            CityCodes.Add("KBP", "Kiev");
            CityCodes.Add("KRS", "Kuressaare");
        }

        private DateTime ReturnDepartureTime(string departureTime) {
            try {
                DateTime depTime = DateTime.Parse(departureTime);
                return depTime;
            } catch (Exception e) {
                Console.WriteLine(e);
                return new DateTime();
            }
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
            } else {
                _flightCodeInvalid = true;
                throw new InvalidFlightCodeException($"Invalid length: {flightCode.Length}");
            }
        }

        private string ReturnFlightCodeInCaps(string flightCode) {
            string flightCodeInCaps = "";
            for (int i = 0; i < 7; i++) {
                flightCodeInCaps += char.ToUpper(flightCode[i]);
            }

            return flightCodeInCaps;
        }
        
        private void CheckCityCodeInFlightCode(string cityCode) {
            if (!CityCodes.ContainsKey(cityCode)) {
                throw new InvalidFlightCodeException(cityCode);
            }
        }
        
        public void SetPriceAndSeats(double price, int nrOfSeats) {
            if (price > 0) {
                _initialPrice = price;
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
                    Console.WriteLine("Ticket {0}:", i + 1);
                    Console.WriteLine(SoldTickets[i].ReturnInfo());
                }
            } else {
                throw new NoTicketsSoldException();
            }
        }

        public void SaveTicketInfo() {
            if (SoldTickets.Count > 0) {
                using (StreamWriter writer = new StreamWriter(SOLD_TICKETS_PATH)) {
                    for (int i = 0; i < SoldTickets.Count; i++) {
                        writer.WriteLine("Ticket {0}:", i + 1);
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
            if (SoldTickets.Count < _nrOfSeats) {
                DateTime buyingTime = DateTime.Now;
            }
        }

        public void SellTicket(string name, string buyingTime) {
            if (SoldTickets.Count < _nrOfSeats) {
                
            }
        }
    }
}