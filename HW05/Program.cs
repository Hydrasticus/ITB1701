using System;
using System.Collections.Generic;
using System.IO;

namespace HW05 {
    internal class Program {
        public static void Main(string[] args) {
            FindCompoundInterest(2200, 0, -2);
            FindCompoundInterest(2200, -5, 2);
            FindCompoundInterest(-2200, 2.1, 2);
            FindCompoundInterest(2200, 2.1, 2);
            
            FixIdCodes();
            
            List<int> ints = new List<int>() { 3, 5, 3, 11, 9 };
            List<int> ints2 = new List<int>() { 7, 5, 3, 9 };
            
            GetMedianAndArithmeticMean(ints);
            GetMedianAndArithmeticMean(ints2);
            
            GetMoney(207);
            GetMoney(101);
            GetMoney(95);
            GetMoney(100);
            GetMoney(1);
            GetMoney(0);
            GetMoney(-1);
            GetMoney(1000);
            
            TvRemote tvRemote = new TvRemote();
            tvRemote.ChangeChannel(5);
            tvRemote.PreviousChannel();
            tvRemote.NextChannel();
            tvRemote.DecreaseVolume();
            tvRemote.IncreaseVolume();
            
            tvRemote.PowerButton();
            tvRemote.PowerButton();
            tvRemote.PowerButton();
            
            tvRemote.ChangeChannel(-1);
            tvRemote.ChangeChannel(101);
            tvRemote.ChangeChannel(0);
            tvRemote.PreviousChannel();
            tvRemote.NextChannel();
            tvRemote.ChangeChannel(100);
            tvRemote.NextChannel();
            tvRemote.PreviousChannel();
            
            tvRemote.DecreaseVolume();
            tvRemote.IncreaseVolume();
            tvRemote.IncreaseVolume();
            tvRemote.IncreaseVolume();
            tvRemote.IncreaseVolume();
            tvRemote.IncreaseVolume();
            tvRemote.IncreaseVolume();
            
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
            if (money < 0 || money > 999) {
                Console.WriteLine("Invalid sum! The minimum amount is 0 EUR and maximum 9 EUR 99 cents.");
            } else {
                string moneyString = money.ToString();
                
                if (money < 100) {
                    if (money == 1) {
                        Console.WriteLine("1 sent");
                    } else
                        Console.WriteLine("{0} senti", money);
                } else {
                    int fullEur = int.Parse(char.GetNumericValue(moneyString[0]).ToString());
                    int cents = int.Parse(char.GetNumericValue(moneyString[1]).ToString() + 
                                          char.GetNumericValue(moneyString[2]).ToString());
                    
                    string eurFormat = "eurot";
                    string centsFormat = "senti";
                    
                    if (fullEur == 1) {
                        eurFormat = "euro";
                    }
                    
                    if (cents == 1) {
                        centsFormat = "sent";
                    }
                    
                    if (cents == 0) {
                        Console.WriteLine("{0} {1}", fullEur, eurFormat);
                    } else {
                        Console.WriteLine("{0} {1} ja {2} {3}",
                        fullEur, eurFormat, cents, centsFormat);
                    }
                }
            }
        }
    }
}