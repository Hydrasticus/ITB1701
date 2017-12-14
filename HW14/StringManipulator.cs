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
                nameArray = FirstCharToUpper(nameArray);
                username = string.Join(" ", nameArray);
            }

            domain = domain.ToUpper();
            
            Console.WriteLine("Name: {0}; Domain: {1}", username, domain);
        }

        public void EncodeAccount(string account) {
            string[] inputArray = account.Split(' ');
            string domain = inputArray[0];
            string username = "";

            if (inputArray.Length > 3) {
                for (int i = 1; i < inputArray.Length - 1; i++) {
                    username += inputArray[i];
                }
                username += "." + inputArray[inputArray.Length - 1];
            } else if (inputArray.Length == 3) {
                username = inputArray[1] + "." + inputArray[2];
            } else {
                username = inputArray[1];
            }

            username = username.ToLower();
            domain = domain.ToLower();
            string shortDomain = domain.Split('.')[0];

            Console.WriteLine("{0}@{1}, {2}\\{0}", username, domain, shortDomain);
        }

        private string[] FirstCharToUpper(string[] inputArray) {
            for (int i = 0; i < inputArray.Length; i++) {
                string input = inputArray[i];
                char firstChar = char.ToUpper(input[0]);
                inputArray[i] = firstChar + input.Substring(1, input.Length - 1);
            }

            return inputArray;
        }
    }
}