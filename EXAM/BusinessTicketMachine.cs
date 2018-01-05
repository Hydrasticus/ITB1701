using System.Collections.Generic;

namespace EXAM {
    public class BusinessTicketMachine : ITicketMachine{
        private Dictionary<string, string> FlightCodes = new Dictionary<string, string>();

        public void TicketMachine(string flightCode, string departureTime) {
            FlightCodes.Add("TLN", "Tallinn");
            FlightCodes.Add("TYO", "Tokyo");
            FlightCodes.Add("BER", "Berlin");
            FlightCodes.Add("KBP", "Kiev");
            FlightCodes.Add("KRS", "Kuressaare");
        }

        private void CheckFlightCode(string flightCode) {
            if (flightCode.Length == 9 || flightCode.Length == 10) {
                string company = flightCode.Substring(0, 2);
                string cityA = flightCode.Substring(2, 3);
                string cityB = flightCode.Substring(5, 3);
                string direction = flightCode.Substring(8, 1);
                if (flightCode.Length == 10) {
                    string ticketClass = flightCode.Substring(9, 1);
                }
            }
        }

        public void SetPriceAndSeats() {
            
        }

        public void PrintTicketInfo() {
            
        }

        public void SaveTicketInfo() {

        }

        public void PrintNrOfFreeSeats() {
            
        }

        public void SellTicket(string buyersName) {
            
        }

        public void SellTicket(string buyersName, string buyingTime) {
            
        }
    }
}