namespace EXAM {
    public interface ITicketMachine {
        void SetPriceAndSeats(double price, int nrOfSeats);
        void PrintTicketInfo();
        void SaveTicketInfo();
        void PrintNrOfFreeSeats();
        void SellTicket(string name);
        void SellTicket(string name, string buyingTime);
    }
}