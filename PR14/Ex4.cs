using System;

namespace PR14 {
    public class Ex4 {
        public void DecodeEmail(string email) {
            string[] emailArray = email.Split('@');

            string nameArray = emailArray[0];
            string[] domainArray = emailArray[1].Split('.');

            string domainName = domainArray[0];

            string[] nameParts = nameArray.Split(new char[] {'.', '-'});
            string name = string.Join(" ", nameParts);
            
            Console.WriteLine("{0}; domain: {1}", name, domainName);
        }

        public void EncodeEmail(string input) {
            string[] inputArray = input.Split(' ');

            if (inputArray.Length >= 3) {
                string delimiter = (inputArray[inputArray.Length - 1]);
                string domain = inputArray[inputArray.Length - 2];

                string[] nameArray = new string[inputArray.Length - 2];

                for (int i = 0; i < nameArray.Length; i++) {
                    nameArray[i] = inputArray[i];
                }
                
                for (int i = 0; i < nameArray.Length; i++) {
                    nameArray[i] = FirstToUpper(nameArray[i]);
                }
                
                string name = string.Join(delimiter, nameArray);
                Console.WriteLine(name + "@" + domain);
            } else {
                Console.WriteLine("Enter at least three parameters!");
            }
        }

        private string FirstToUpper(string input) {
            char[] chars = input.ToCharArray();
            chars[0] = char.ToUpper(chars[0]);

            string output = "";
            foreach (char c in chars) {
                output += c;
            }

            return output;
        }
    }
}