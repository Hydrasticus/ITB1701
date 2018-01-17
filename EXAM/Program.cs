namespace EXAM {
    internal class Program {
        public static void Main(string[] args) {
            EconomyTicketMachine etm = new EconomyTicketMachine("EATLLTYO5b", "2018-03-20");
            etm.SetPriceAndSeats(100, 50);
            etm.SellTicket("Jeesus Kristus");
        }
    }
}