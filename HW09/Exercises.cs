using System;
using System.Collections.Generic;

namespace HW09 {
    public class Exercises {
        Random random = new Random();
        
        public string JoinTwoStrings(string a, string b) {
            return a + b;
        }

        public int[] ReturnArray() {
            int[] listOfInts;
            int div5Counter, evenCounter, oddCounter;

            do {
                div5Counter = 0;
                evenCounter = 0;
                oddCounter = 0;
                
                listOfInts = GenerateArray();
                foreach (int integer in listOfInts) {
                    if (integer % 5 == 0) {
                        div5Counter++;
                    }

                    switch (integer % 2) {
                        case 0:
                            evenCounter++;
                            break;
                        case 1:
                            oddCounter++;
                            break;
                    }
                }
            } while (div5Counter < 1 || evenCounter < 2 || oddCounter < 2);
            
            return listOfInts;
        }

        private int[] GenerateArray() {
            int[] listOfInts = new int[6];

            for (int i = 0; i <= 1; i++) {
                listOfInts[i] = random.Next(0, 21);
            }
            
            for (int i = 2; i <= 3; i++) {
                listOfInts[i] = random.Next(30, 61);
            }

            for (int i = 4; i <= 5; i++) {
                listOfInts[i] = random.Next(100, 201);
            }

            return listOfInts;
        }
        
        public string CalculateBMI(double weightInKilos, double heightInMetres) {
            double valueOfBMI = weightInKilos / Math.Pow(heightInMetres, 2);
            string output;

            if (valueOfBMI < 18.5) {
                output = "Underweight";
            } else if (valueOfBMI >= 18.5 && valueOfBMI < 25) {
                output = "Normal";
            } else if (valueOfBMI >= 25 && valueOfBMI < 30) {
                output = "Overweight";
            } else
                output = "Obese";
            
            return output;
        }

        public string ReplaceSpaces(string input) {
            string[] wordArray = input.Split(' ');
            List<string> cleanWords = new List<string>();
            foreach (string word in wordArray) {
                if (word != "") {
                    cleanWords.Add(word);
                }
            }

            return string.Join("*", cleanWords);
        }
    }
}