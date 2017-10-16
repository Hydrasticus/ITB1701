using System;

namespace PR07 {
    public class BronzeTicketMachine : SilverTicketMachine {
        internal int _ticketCounter = 0;
        internal const int REQ_COUNT = 5;
        internal const double DISCOUNT = 0.1;

        public BronzeTicketMachine() {
            _ticketType = "Bronze";
        }

        public BronzeTicketMachine(string ticketType) {
            _ticketType = ticketType;
        }

        public override void SellTicket(int distance) {
            if (distance >= 0 && distance <= 80) {
                _ticketCounter++;
                FindPrice(distance);
                ShowTicketInfo();
            } else 
                Console.WriteLine("Invalid distance: {0}. Ticket not sold.", distance);
        }

        internal override void FindPrice(int distance) {
            base.FindPrice(distance);
            CalculateDiscount();
        }

        private void CalculateDiscount() {
            if (_ticketCounter == REQ_COUNT) {
                _ticketCounter = 0;
                _price = _price * DISCOUNT;
            }
        }
    }
}