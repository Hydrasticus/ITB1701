using System;
using System.Collections.Generic;

namespace HW02 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Time to add 'a' to every god damn letter in your string." +
                          "\nEnter some random text here: ");
            string modifyString = Console.ReadLine();

            PrintModifiedString(modifyString);

            Console.Write("\nNow let's turn some lowercase letters into uppercase." +
                          "\nEnter some random text here: ");
            string lowerString = Console.ReadLine();

            PrintUpperCaseString(lowerString);

            Console.Write("\nList. Enter the first item to put into a list: ");
            string firstEntry = Console.ReadLine();
            Console.Write("The second item: ");
            string secondEntry = Console.ReadLine();
            Console.Write("The third item: ");
            string thirdEntry = Console.ReadLine();

            GetSortedList(firstEntry, secondEntry, thirdEntry);
            
            Console.Write("Enter the array size: ");
            int randomInt = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The sum of random integers is: {0}", GetSumOfRandomIntegers(randomInt));
            
            Console.Write("\nEnter the number (between 1-10) that I'm thinking of: ");
            int guessNumber = Int32.Parse(Console.ReadLine());

            GetNumber(guessNumber);

            Console.WriteLine("\nUse 'Enter' to exit the application.");
            Console.ReadLine();
        }
        public static void PrintModifiedString(string s) {
            char[] characters = s.ToCharArray();

            Console.Write("Result: ");
            for (int i = 0; i < s.Length; i++) {
                Console.Write(characters[i] + "a");
            }
            Console.WriteLine();
        }
        public static void PrintUpperCaseString(string s) {
            if (s == s.ToUpper()) {
                Console.WriteLine("The string is already uppercase!");
            } else {
                Console.WriteLine("Result: {0}", s.ToUpper());
            }
        }
        public static void GetSortedList(string s, string t, string u) {
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add(s);
            listOfStrings.Add(t);
            listOfStrings.Add(u);
            listOfStrings.Sort();

            Console.WriteLine("\nResults in the sorted list are: {0}, {1}, {2}.", 
                listOfStrings[0], listOfStrings[1], listOfStrings[2]);
        }
        public static int GetSumOfRandomIntegers(int n) {
            int[] arrayOfInts = new int[n];
            int sum = 0;
            Random random = new Random();

            for (int i = 0; i < n; i++) {
                arrayOfInts[i] = random.Next(0, 50);
                sum += arrayOfInts[i];
            }

            return sum;
        }
        public static void GetNumber(int n) {
            int predefinedNumber = 4;
            
            while (predefinedNumber != n) {
                Console.Write("That is not the number I am thinking of, try again: ");
                n = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Correct! That is the number I am thinking of!");
        }
    }
}
