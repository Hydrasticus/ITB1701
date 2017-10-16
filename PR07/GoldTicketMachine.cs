using System;
using System.Collections.Generic;

namespace PR07 {
    public class GoldTicketMachine : BronzeTicketMachine {
        internal const int REQ_COUNT = 4;
        internal const double DISCOUNT = 0.2;
        private List<int> _prices = new List<int>() {5, 7, 9};
        
        public GoldTicketMachine() {
            _ticketType = "Gold";
        }

        public GoldTicketMachine(string ticketType) {
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
                _price -= _price * DISCOUNT;
            }
        }
    }
}