using System;

namespace EXAM {
    internal class Program {
        public static void Main(string[] args) {
            Random rnd = new Random();
            
            EconomyTicketMachine etm = new EconomyTicketMachine("EATLLTYO5b", "2018-03-20", 5);
            etm.SetPriceAndSeats(100, 55);

            string[] names = new[] {
                "Mari", "Kari", "Juudas", "Toots", "Megamees", "Josif Josif", "The best",
                "Über Natürlich", "Karl Friedrich", "Saku Originaal"
            };

            for (int i = 0; i < 60; i++) {
                etm.SellTicket(names[rnd.Next(0, 10)]);
            }

            Console.ReadLine();
        }
    }
}