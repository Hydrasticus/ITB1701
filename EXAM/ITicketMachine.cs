namespace EXAM {
    public interface ITicketMachine {
        void TicketMachine(string flightCode, string departureTime);
        void SetPriceAndSeats(double price, int nrOfSeats);
        void PrintTicketInfo();
        void SaveTicketInfo();
        void PrintNrOfFreeSeats();
        void SellTicket(string buyersName);
        void SellTicket(string buyersName, string buyingTime);
    }
}