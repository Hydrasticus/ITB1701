using System.Collections.Generic;

namespace PR07 {
    public class GoldTicketMachine : BronzeTicketMachine {
        // TODO: fix
        
        internal const int REQ_COUNT = 4;
        internal const double DISCOUNT = 0.2;
        private List<int> _prices = new List<int>() {5, 7, 9};
        
        public GoldTicketMachine() {
            _ticketType = "Gold";
        }

        public GoldTicketMachine(string ticketType) {
            _ticketType = ticketType;
        }

        internal override void FindPrice(int distance) {
            base.FindPrice(distance);
            switch (_zone) {
                case "Zone A":
                    _price = _prices[0];
                    break;
                case "Zone B":
                    _price = _prices[1];
                    break;
                case "Zone C":
                    _price = _prices[2];
                    break;
            }
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