using System;

namespace EXAM {
    public class EconomyTicketMachine : BusinessTicketMachine {
        private int _extraSeats, _nrOfBaseSeats;
        
        public EconomyTicketMachine(string flightCode, string departureTime) : base(flightCode, departureTime) {
            _ticketType = 2;
            _priceMultiplier = 1;
        }

        public EconomyTicketMachine(string flightCode, string departureTime, int extraSeats) : base(flightCode, departureTime) {
            _ticketType = 2;
            _priceMultiplier = 1;
            _extraSeats = extraSeats;
        }

        public override void SetPriceAndSeats(double price, int nrOfSeats) {
            base.SetPriceAndSeats(price, nrOfSeats);
            _nrOfBaseSeats = nrOfSeats;
            _nrOfSeats = _nrOfBaseSeats + _extraSeats;
        }

        internal override bool CanSellTicket() {
            return true;
        }
        
        internal override double CalculateTicketPrice(DateTime buyingTime) {
            double price = base.CalculateTicketPrice(buyingTime);
            
            if (_departureTime.DayOfWeek == DayOfWeek.Friday || _departureTime.DayOfWeek == DayOfWeek.Saturday) {
                 price = price * 1.15;
            }

            return price;
        }
    }
}