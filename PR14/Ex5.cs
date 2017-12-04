using System;

namespace PR14 {
    public class Ex5 {
        private int amount;
        private const int MAX_CITIES = 500;
        private bool finished = false;
        
        public void Cities() {
            string[] cities = new string[MAX_CITIES];
            int[] inhabitants = new int[MAX_CITIES];

            amount = 0;
            DisplayOptions();
            
            string option = Console.ReadLine();

            while (!finished) {
                switch (option) {
                    case "0":
                        finished = true;
                        break;
                    case "1":
                        if (amount < MAX_CITIES) {
                            Console.Write("");
                        } else {
                            Console.WriteLine("The database is full!");
                        }
                        break;
                    case "2":
                        for (int i = 0; i < amount; i++) {
                            Console.WriteLine("{0}, inhabitants: {1}", cities[i], inhabitants[i]);
                        }
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                }
            }
        }

        private void DisplayOptions() {
            Console.WriteLine("1 - Add a new city\n2 - View all cities\n3 - Modify a record\n4 - Insert a new record\n" +
                              "5 - Delete a record\n6 - Search in the records\n" +
                              "7 - Correct the capitalization of names\n" +
                              "0 - Exit");
        }

        private void AddNewCity() {
            
        }
    }
}