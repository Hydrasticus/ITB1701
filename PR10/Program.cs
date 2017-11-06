using System;

namespace PR10 {
    internal class Program {
        public static void Main(string[] args) {
            ShapeFactory sf = new ShapeFactory();
            
            IShape shape1 = sf.GetShape(3);
            shape1.Draw();
            
            IShape shape2 = sf.GetShape(4);
            shape2.Draw();
            
            IShape shape3 = sf.GetShape(0);
            shape3.Draw();
            
            /*
            // Exercise 2
            Book niceBook = new Book();
            niceBook.Title = "The Day of the Triffids";
            niceBook.Genre = BookGenre.SciFi;
            
            Book dramaBook = new Book("Some drama");
            dramaBook.Genre = BookGenre.Drama;
            
            Library schooLibrary = new Library();
            schooLibrary.AddBook(niceBook);
            
            Console.WriteLine(schooLibrary.GetNumberOfBooksInLibrary());
            Book foundBook = schooLibrary.FindBookByName("The day");


            if (foundBook != null) {
                Console.WriteLine(foundBook.Title);
            }
            */
            
            /*
            // Exercise 1
            Dice dice = new Dice();
            dice.DrawDice();

            string userEntry = "";
            
            while (userEntry != "N" || userEntry != "n") {
                Console.CursorLeft = 0;
                Console.CursorTop = 10;
                
                Console.WriteLine("Do you want to generate moar random shit? Y/N");
                userEntry = Console.ReadLine();
                
                dice.RollDice();
            }
            */
            //Console.ReadLine();
        }
    }
}