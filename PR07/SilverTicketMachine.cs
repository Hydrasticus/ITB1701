using System;
using System.Collections.Generic;

namespace PR07 {
    public class SilverTicketMachine : ITicket {
        private List<int> _prices = new List<int>() {3, 4, 5};
        internal string _ticketType;
        internal string _zone;
        internal double _price;
        
        public SilverTicketMachine() {
            _ticketType = "Silver";
        }

        public SilverTicketMachine(string ticketType) {
            _ticketType = ticketType;
        }
        
        public virtual void SellTicket(int distance) {
            FindPrice(distance);
            
            if (distance >= 0 && distance <= 80) {
                ShowTicketInfo();
            } else
                Console.WriteLine("Invalid distance: {0}. Ticket not sold.", distance);
        }
        
        internal virtual void FindPrice(int distance) {
            if (distance >= 0 && distance <= 30) {
                _zone = "Zone A";
                _price = _prices[0];
            } else if (distance >= 31 && distance <= 60) {
                _zone = "Zone B";
                _price = _prices[1];
            } else if (distance >= 61 && distance <= 80) {
                _zone = "Zone C";
                _price = _prices[2];
            }
        }
        
        internal void ShowTicketInfo() {
            Console.WriteLine("-- Ticket info --\n Name: {0}\n Zone: {1}\n Price: {2} EUR\n",
                _ticketType, _zone, _price);
        }
    }
}