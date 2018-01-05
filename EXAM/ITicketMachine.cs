namespace EXAM {
    public interface ITicketMachine {
        void TicketMachine(string flightCode, string departureTime);
        void SetPriceAndSeats();
        void PrintTicketInfo();
        void SaveTicketInfo();
        void PrintNrOfFreeSeats();
        void SellTicket(string buyersName);
        void SellTicket(string buyersName, string buyingTime);
    }
}