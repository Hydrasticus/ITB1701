using System;
using System.Collections.Generic;

namespace HW09 {
    public class Exercises {
        public string JoinTwoStrings(string a, string b) {
            return a + b;
        }

        public int[] ReturnArray() {
            //TODO
            int[] listOfInts = new int[6];
            
            return listOfInts;
        }

        public string CalculateBMI(double weight, double height) {
            string output = "";
            double valueOfBMI = weight / Math.Pow(height, 2);
            
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

        public string ReplaceSpace(string input) {
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