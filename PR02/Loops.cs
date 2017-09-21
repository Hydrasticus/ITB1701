using System;
using System.Collections.Generic;

namespace PR02 {
    class Loops {
        static void Main(string[] args) {
            //SpongeBob(Console.ReadLine());
            //Console.ReadLine();

            int[] nums = new int[10];
            nums[0] = 1;
            nums[7] = 8;

            int b = 10;

            for (int i = 0; i < 10; i++) {
                nums[i] = b;
                b--;
            }

            foreach (int u in nums) {
                if (u % 2 == 0) {
                    Console.WriteLine(u);
                }
            }

            /*
            List<int> listOfHundredInts = new List<int>();

            int i = 1;
            while (listOfHundredInts.Count < 100) {
                listOfHundredInts.Add(i);
                i++;
            }

            Console.WriteLine("The count is {0}"., listOfHundredInts.Count);
            */
            /*
            string a = Console.ReadLine();
            while (a.Length != 4) {
                Console.WriteLine("String length is not 4, try again!");
                a = Console.ReadLine();
            }
            Console.WriteLine("String has length of 4.");
            Console.ReadLine();
            */
            /*
            for (i = 1; i <= 100; i++) {
                listOfHundredInts.Add(i);
            }

            Console.WriteLine("The list count is {0}.", listOfHundredInts.Count);
            
            foreach (int a in listOfHundredInts) {
                Console.WriteLine(a);
            }
            */
            /*
            List<string> myList = GetListOfFruits();
            List<int> numberList = GetListOfNumbers();

            for (int i = 1; i <= 10; i++) {
                Console.WriteLine("The index is: " + i);
            }

            for (int i = 0; i < myList.Count; i++) {
                Console.WriteLine("The item is {0}.", myList[i]);
            }
            
            foreach (string fruit in myList) {
                Console.WriteLine(fruit);
            }
            
            int sum = 0;

            foreach (int number in numberList) {
                sum = sum + number;
                Console.WriteLine("The sum is {0}.", sum);
            }
            */
            Console.ReadLine();
        }
        //Teha veel
        public static void SpongeBob(string s) {
            char[] insult = s.ToCharArray();
            List<string> uppercase = new List<string>();
            int i = 0;
            int k = insult[i];
            
            foreach (int u in insult) {
                if (u%2 == 0) {
                    uppercase.Add(u.ToString());
                }
            }


            while (i < insult.Length) {
                Console.Write(insult[i]);
                i++;
            }
        }
        public static string ReverseString(string initialString) {
            return initialString;
        }
        public static List<string> GetListOfFruits() {
            List<string> listOfFruits = new List<string>();
            listOfFruits.Add("banana");
            listOfFruits.Add("tomato");
            listOfFruits.Add("orange");

            return listOfFruits;
        }
        public static List<int> GetListOfNumbers() {
            List<int> listOfNumbers = new List<int>();
            listOfNumbers.Add(1); //[0]
            listOfNumbers.Add(2); //[1]
            listOfNumbers.Add(3); //[2]

            return listOfNumbers;
        }
    }
}
