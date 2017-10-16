using System;
using System.Collections.Generic;
using System.IO;

namespace PR07 {
    static class Program {
        public static void Main(string[] args) {
            SilverTicketMachine silver = new SilverTicketMachine();
            silver.SellTicket(-1); // Invalid
            silver.SellTicket(0); // Zone A
            silver.SellTicket(30); // Zone A
            silver.SellTicket(31); // Zone B
            silver.SellTicket(60); // Zone B
            silver.SellTicket(61); // Zone C
            silver.SellTicket(80); // Zone C
            silver.SellTicket(81); // Invalid
            
            BronzeTicketMachine bronze = new BronzeTicketMachine();
            bronze.SellTicket(-1); // Invalid
            bronze.SellTicket(0); // Zone A
            bronze.SellTicket(30); // Zone A
            bronze.SellTicket(31); // Zone B
            bronze.SellTicket(60); // Zone B
            bronze.SellTicket(61); // Zone C - discounted price
            bronze.SellTicket(80); // Zone C
            bronze.SellTicket(81); // Invalid

            GoldTicketMachine gold = new GoldTicketMachine();
            gold.SellTicket(-1); // Invalid
            gold.SellTicket(0); // Zone A
            gold.SellTicket(30); // Zone A
            gold.SellTicket(31); // Zone B
            gold.SellTicket(60); // Zone B - discounted price
            gold.SellTicket(61); // Zone C
            gold.SellTicket(80); // Zone C
            gold.SellTicket(81); // Invalid

            /*
             * Korda järgmiseks nädalaks:
             * - Classes
             * - Interfaces
             * - Base/derived classes
             * - Constructors
             * - Methods
             */
            
            /*
            // Exercise 4
            List<int> listofInts = new List<int>();
            try {
                Console.WriteLine(listofInts[1]);
            } catch (ArgumentOutOfRangeException ex) {
                if (listofInts.Count == 0) {
                    Console.WriteLine("No index is applicable!");
                } else
                    Console.WriteLine("Maximum value of the index could be: " + listofInts.Count);
            }
            */
            
            /*
            // Exercise 3
            Division(12, 0);
            Division(10, 5);
            */
            
            /*
            // Exercise 2
            DoesFileExist("wrongFile");
            DoesFileExist(null);
            DoesFileExist("PR07.exe");
            */
            
            /*
            // Exercise 1
            bool wasNotNumber = true;
            int parsedValue;
            Console.Write("Enter a number: ");
            while (wasNotNumber) {
                try {
                    parsedValue = int.Parse(Console.ReadLine());
                    wasNotNumber = false;
                    Console.WriteLine("Thanks, was a number!");
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                    Console.Write("Enter a number: ");
                    wasNotNumber = true;
                }
            }
            */
            
            Console.ReadLine();
        }

        static void DoesFileExist(string fileName) {
            // Exercise 2
            try {
                using (StreamReader reader = new StreamReader(fileName)) {
                }
                Console.WriteLine("File exists!");
            } catch (FileNotFoundException ex) { // There is no file with that name to begin with
                Console.WriteLine("The file with URL {0} does not exist.", ex.FileName);
            } catch (ArgumentNullException ex) { // The god damn diddly dang file name is null
                Console.WriteLine("The file name is null.");
            }
        }

        static void Division(int a, int b) {
            // Exercise 3
            int result;
            try {
                result = a / b;
            } catch (DivideByZeroException ex) {
                Console.WriteLine("You attempted to divide by zero. You overestimate my computing power. "
                                  + "Let's instead divide by two.");
                b = 2;
                result = a / b;
            }
            Console.WriteLine("{0} / {1} = {2}", a, b, result);
        }
    }
}