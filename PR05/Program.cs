using System;
using System.IO;
using System.Linq;

namespace PR05 {
    internal class Program {
        public static void Main(string[] args) {
            // SoupCalculator();
            
            /*
            Console.WriteLine(RegistrationNumberValidator("123ABC"));
            Console.WriteLine(RegistrationNumberValidator("921BCD"));
            Console.WriteLine(RegistrationNumberValidator("ABCABC"));
            Console.WriteLine(RegistrationNumberValidator("123123"));
            Console.WriteLine(RegistrationNumberValidator("123ÕÄA"));
            Console.WriteLine(RegistrationNumberValidator("123ÄBC"));
            Console.WriteLine(RegistrationNumberValidator("123PÜR"));
            */
            
            /*
            ConvertTemperature("120F");
            ConvertTemperature("69C");
            ConvertTemperature("0F");
            ConvertTemperature("0C");
            ConvertTemperature("998AF");
            ConvertTemperature("13BC");
            ConvertTemperature("tere");
            */
            
            // GenerateDetailCodes();
            
            /*
            Console.WriteLine(PalindromeFinder("madam"));
            Console.WriteLine(PalindromeFinder("racecar"));
            Console.WriteLine(PalindromeFinder("dildo"));
            Console.WriteLine(PalindromeFinder("mm"));
            Console.WriteLine(PalindromeFinder("a"));
            */
            
            GetNumberConsistency("43928");
            
            /*
            TvRemote tvRemote = new TvRemote();
            
            tvRemote.IncreaseVolume();
            tvRemote.DecreaseVolume();
            
            tvRemote.TurnOnSystem();
            
            tvRemote.DecreaseVolume();
            tvRemote.IncreaseVolume();
            tvRemote.IncreaseVolume();
            tvRemote.IncreaseVolume();
            tvRemote.IncreaseVolume();
            tvRemote.IncreaseVolume();
            tvRemote.IncreaseVolume();
            tvRemote.IncreaseVolume();
            
            tvRemote.TurnOffSystem();
            */
            
            Console.ReadLine();
        }

        public static void SoupCalculator() {
            // Task 1
            
            double soupTemp = 60, roomTemp = 20;

            double deltaTemp = soupTemp - roomTemp;

            if (soupTemp > roomTemp) {
                for (int i = 1; i <= 7; i++) {
                    soupTemp -= deltaTemp * 0.13;
                    deltaTemp = soupTemp - roomTemp;
                }
            }

            Console.WriteLine("The soup temperature after 7 minutes is {0} degrees.", Math.Round(soupTemp, 2));
        }

        public static bool RegistrationNumberValidator(string numberString) {
            // Task 2
            
            if (numberString.Length != 6) {
                return false;
            }
            
            string numbers = numberString.Substring(0, 3);
            string letters = numberString.Substring(3, 3);
            
            if (!numbers.All(char.IsDigit) || !letters.All(char.IsLetter)) {
                return false;
            }
            
            char[] unwantedLetters = new char[8] {'õ', 'ä', 'ö', 'ü', 'Õ', 'Ä', 'Ö', 'Ü'};
            
            if (letters.IndexOfAny(unwantedLetters) != -1) {
                return false;
            }
            
            return true;
        }

        public static void ConvertTemperature(string temp) {
            // Task 3

            if (temp.Length < 2) {
                Console.WriteLine("Invalid temperature!");
            }
            
            string degreeString = temp.Substring(0, (temp.Length - 1));
            double degree = 0;

            if (!degreeString.All(char.IsDigit)) {
                Console.WriteLine("Invalid temperature!");
            } else {
                degree = double.Parse(degreeString);
                double convertedTemp = 0;
            
                if (temp[temp.Length - 1] == 'C' || temp[temp.Length - 1] == 'c') {
                    // Converts C to F
                    convertedTemp = (degree * 1.8) + 32;
                    
                    Console.WriteLine("The temperature in {0}C is {1} in Fahrenheit.",
                        degree, Math.Round(convertedTemp, 2));
                } else if (temp[temp.Length - 1] == 'F' || temp[temp.Length - 1] == 'f') {
                    // Converts F to C
                    convertedTemp = (degree - 32) / 1.8;
                    
                    Console.WriteLine("The temperature in {0}F is {1} in Celsius.",
                        degree, Math.Round(convertedTemp, 2));
                } else 
                    Console.WriteLine("Invalid temperature!");
            }
        }

        public static void GenerateDetailCodes() {
            // Task 4

            string inputFile = "input.txt";
            string outputFile = "output.txt";

            using (StreamReader reader = new StreamReader(inputFile)) {
                using (StreamWriter writer = new StreamWriter(outputFile)) {
                    string line;
                    Random random = new Random();

                    while ((line = reader.ReadLine()) != null) {
                        int numbersLeft = 6 - line.Length;
                        string code = line;

                        if (code.Contains("x")) {
                            for (int i = 0; i < numbersLeft; i++) {
                                code = code + random.Next(0, 0);
                            }
                        } else for (int i = 0; i < numbersLeft; i++) {
                            code = code + random.Next(0, 9);
                        }

                        writer.WriteLine(code);
                    }    
                }
            }
        }

        public static bool PalindromeFinder(string inputWord) {
            // Task 5
            
            if (inputWord.Length >= 2) {
                string outputWord = "";
                char[] reversedWord = inputWord.ToCharArray();
                
                for (int i = inputWord.Length - 1; i >= 0; i--) {
                    outputWord += reversedWord[i];
                }
                
                if (inputWord == outputWord) {
                    return true;
                }
            }
            return false;
        }

        public static void GetNumberConsistency(string number) {
            // Task 6
            // TODO for loop
            
            double output;
            for (int i = number.Length - 1; i >= 0; i--) {
                for (double j = 0; j < number.Length; j++) {
                    output = Char.GetNumericValue(number[i]) * Math.Pow(10, j);
                }
            }
        }
    }
}