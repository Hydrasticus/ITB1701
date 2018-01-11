using System;
using System.Collections.Generic;
using static EXAM.ExceptionClass;

namespace EXAM {
    public class BusinessTicketMachine : ITicketMachine{
        private readonly Dictionary<string, string> FlightCodes = new Dictionary<string, string>();
        private readonly List<Ticket> SoldTickets = new List<Ticket>();
        private DateTime _departureTime;
        private string _origin, _destination;
        private double _initialPrice;
        private int _nrOfSeats;
        private bool _businessAvailable, _flightCodeInvalid; //TODO: find workaround for _flightCodeInvalid

        public void TicketMachine(string flightCode, string departureTime) {
            FlightCodes.Add("TLL", "Tallinn");
            FlightCodes.Add("TYO", "Tokyo");
            FlightCodes.Add("BER", "Berlin");
            FlightCodes.Add("KBP", "Kiev");
            FlightCodes.Add("KRS", "Kuressaare");
            CheckFlightCode(flightCode);
        }

        private void CheckFlightCode(string flightCode) {
            if (flightCode.Length == 9 || flightCode.Length == 10) {
                string cityA = flightCode.Substring(2, 3);
                CheckCityCodeInFlightCode(cityA);

                string cityB = flightCode.Substring(5, 3);
                CheckCityCodeInFlightCode(cityB);
                
                string direction = flightCode.Substring(8, 1);
                switch (int.Parse(direction)) {
                    case 2:
                        _origin = cityA;
                        _destination = cityB;
                        break;
                    case 5:
                        _origin = cityB;
                        _destination = cityA;
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

        private void CheckCityCodeInFlightCode(string cityCode) {
            if (!FlightCodes.ContainsKey(cityCode)) {
                throw new InvalidFlightCodeException(cityCode);
            }
        }

        private void CheckDepartureTime() {
            //TODO
        }
        
        public void SetPriceAndSeats(double price, int nrOfSeats) {
            if (price > 0) {
                _initialPrice = price;
            } else {
                throw new NegativeOrZeroPriceException();
            }

            if (nrOfSeats > 0) {
                _nrOfSeats = nrOfSeats;
            } else {
                throw new NegativeOrZeroNrOfSeatsException();
            }
        }

        public void PrintTicketInfo() {
            if (SoldTickets.Count > 0) {
                foreach (Ticket ticket in SoldTickets) {
                    ticket.PrintInfo();
                }   
            } else {
                throw new NoTicketsSoldException();
            }
        }

        public void SaveTicketInfo() {
            if (SoldTickets.Count > 0) {
                foreach (Ticket ticket in SoldTickets) {
                    
                }
            } else {
                throw new NoTicketsSoldException();
            }
        }

        public void PrintNrOfFreeSeats() {
            int nrOfFreeSeats = _nrOfSeats - SoldTickets.Count;
            Console.WriteLine("Free seats: {0}", nrOfFreeSeats);
        }

        public void SellTicket(string buyersName) {
            
        }

        public void SellTicket(string buyersName, string buyingTime) {
            
        }
    }
}