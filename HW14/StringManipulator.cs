using System;

namespace HW14 {
    public class StringManipulator {
        public void DecodeAccount(string account) {
            string[] inputArray;
            string domain = "";
            string username = "";

            if (account.Contains(@"\")) {
                inputArray = account.Split('\\');
                domain = inputArray[0];
                username = inputArray[1];
            } else if (account.Contains("@")) {
                inputArray = account.Split('@');
                username = inputArray[0];
                if (inputArray[1].Contains(".")) {
                    string[] domainArray = inputArray[1].Split('.');
                    domain = domainArray[0];
                } else {
                    domain = inputArray[1];
                }
            }

            if (domain.Contains("i:0#.w|")) {
                string[] domainArray = domain.Split('|');
                domain = domainArray[1];
            }

            if (username.Contains(".")) {
                string[] nameArray = username.Split('.');
                foreach (string n in nameArray) {
                    FirstCharToUpper(nameArray);
                }
            }
            
            Console.WriteLine("Name: {0}, Domain: {1}", username, domain.ToUpper());
        }

        public void EncodeAccount(string account) {
            
        }

        private string[] FirstCharToUpper(string[] inputArray) {
            foreach (string input in inputArray) {
                char firstChar = input[0];
                firstChar = char.ToUpper(input[0]);
                input.Replace(input[0], firstChar);
            }

            return inputArray;
        }
    }
}