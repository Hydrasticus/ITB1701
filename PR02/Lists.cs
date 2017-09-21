using System;
using System.Collections.Generic;

namespace PR02 {
    class Lists {
        static void Main(string[] args) {
            List<string> myList = GetListOfFruits();
            Console.WriteLine(myList.Count);

            Console.ReadLine();
        }
        public static List<string> GetListOfFruits() {
            List<string> listOfFruits = new List<string>();
            listOfFruits.Add("banana");
            listOfFruits.Add("tomato");
            listOfFruits.Add("orange");
            /*
            Console.WriteLine(listOfFruits.Count);
            Console.WriteLine(listOfFruits[1]);

            listOfFruits.RemoveAt(1);
            Console.WriteLine(listOfFruits.Count);
            Console.WriteLine(listOfFruits[1]);

            List<string> dogs = new List<string>();
            dogs.Add("terrier");
            dogs.Add("chihuahua");
            dogs.Add("german shepherd");
            dogs.Add("doggo");
            dogs.Add("doge");
            dogs.Add("doooooooog");

            listOfFruits.Add("pineapple");
            listOfFruits.Add("leaf");

            listOfFruits.AddRange(dogs);
            Console.WriteLine(listOfFruits.Count);
            */
            return listOfFruits;
        }
    }
}
