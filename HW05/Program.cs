using System;
using System.Collections.Generic;
using System.IO;

namespace HW05 {
    internal class Program {
        public static void Main(string[] args) {
            //FindCompoundInterest(2200, 0, -2);
            //FindCompoundInterest(2200, 2.1, 2);
            //FindCompoundInterest(2200, 2.1, 2);
            
            //FixIdCodes();

            //List<int> ints = new List<int>() { 3, 5, 3, 11, 9 };
            //List<int> ints2 = new List<int>() { 7, 5, 3, 9 };
            
            //GetMedianAndArithmeticMean(ints);
            //GetMedianAndArithmeticMean(ints2);
            
            GetMoney(207);
            GetMoney(101);
            GetMoney(95);
            GetMoney(100);
            GetMoney(1);
            GetMoney(0);
            GetMoney(100);

            Console.ReadLine();
        }

        public static void FindCompoundInterest(int initialSum, double interestRate, int years) {
            if (initialSum < 0 || interestRate < 0 || years < 0) {
                Console.WriteLine("Inputs cannot be negative!");
            } else {
                double finalSum = initialSum;

                Console.WriteLine("Initial amount: {0} EUR, interest rate: {1}%, years: {2}",
                    initialSum, interestRate, years);

                for (int i = 1; i <= years; i++) {
                    double interest = finalSum * (interestRate / 100);
                    finalSum += interest;

                    Console.WriteLine(" Monetary amount by the {0}. year: {1} EUR",
                        i, Math.Round(finalSum, 2));
                }
            }
            
            Console.WriteLine();
        }

        public static void FixIdCodes() {
            string firstReadPath = "id.txt";
            string secondReadPath = "trololo.txt";
            string writePath = "fixed_codes.txt";
            
            List<string> idCodeBegins = new List<string>();
            using (StreamReader reader = new StreamReader(firstReadPath)) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    idCodeBegins.Add(line);
                }
            }
            
            List<string> idCodeEnds = new List<string>();
            using (StreamReader reader = new StreamReader(secondReadPath)) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    idCodeEnds.Add(line);
                }
            }
            
            List<string> fixedIdCodes = new List<string>();
            while (fixedIdCodes.Count != 6) {
                foreach (string beginning in idCodeBegins) {
                    foreach (string ending in idCodeEnds) {
                        if (beginning.Length + ending.Length == 11) {
                            string fixedId = beginning + ending;
                            fixedIdCodes.Add(fixedId);
                        }
                    }
                }
            }
            
            using (StreamWriter writer = new StreamWriter(writePath)) {
                foreach (string fixedId in fixedIdCodes) {
                    writer.WriteLine(fixedId);
                }
            }
        }

        public static void GetMedianAndArithmeticMean(List<int> listOfInts) {
            listOfInts.Sort();
            
            double median;
            if (listOfInts.Count % 2 == 0) {
                int count = listOfInts.Count;
                median = (listOfInts[(count / 2) - 1] + listOfInts[(count / 2)]) / 2;
            } else
                median = listOfInts[listOfInts.Count / 2];
            
            double mean = 0;
            foreach (int i in listOfInts) {
                mean += i;
            }
            mean = mean / listOfInts.Count;
            
            Console.WriteLine("The median of given list of integers is {0} and arithmetic mean {1}.",
                median, Math.Round(mean, 2));
        }

        public static void GetMoney(int money) {
            // TODO: the whole damn method (too complicated at the moment)
            
            if (money < 0 || money > 999) {
                Console.WriteLine("The minimum amount is 0 EUR and maximum 9 EUR 99 cents.");
            } else {
                string moneyString = money.ToString();
                string cents = "senti";

                if (money == 1) {
                    Console.WriteLine("{0} sent", money);
                }
                
                if (money < 100) {
                    Console.WriteLine("{0} senti", money);
                } else {
                    if (moneyString[0] == 1) {
                        if (moneyString[2] == 1) {
                            Console.WriteLine("{0} euro ja {1} sent", moneyString[0], moneyString[2]);
                        } else {
                            Console.WriteLine("{0} euro ja {1} senti", moneyString[0], (money - 100));
                        }
                    } else 
                        Console.WriteLine("{0} eurot ja {1} senti", moneyString[0], moneyString[1]);
                }
            }
        }
    }
}