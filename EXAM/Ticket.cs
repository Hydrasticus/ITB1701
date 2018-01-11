using System;

namespace EXAM {
    public class Ticket {
        private string _passengerName, _origin, _destination;
        private DateTime _flightDate;
        private double _price;
        private int _seatNr, _ticketType;

        public string PassengerName {
            get => _passengerName;
            set => _passengerName = value;
        }

        public DateTime FlightDate {
            get => _flightDate;
            set => _flightDate = value;
        }

        public double Price {
            get => _price;
            set => _price = value;
        }

        public string Origin {
            get => _origin;
            set => _origin = value;
        }

        public string Destination {
            get => _destination;
            set => _destination = value;
        }

        public int TicketType {
            get => _ticketType;
            set => _ticketType = value;
        }

        public int SeatNr {
            get => _seatNr;
            set => _seatNr = value;
        }

        public string ReturnInfo() {
            return
                $"== TICKET INFO ==\nName: {PassengerName}\nFlight date: {FlightDate}\nPrice: {Price} €\nFrom: {Origin}" +
                $"\nTo: {Destination}\nTicket type: {TicketType}\nSeat number: {SeatNr}\nHave a nice flight!\n";
        }
    }
}