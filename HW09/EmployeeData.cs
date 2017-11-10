using System.Collections.Generic;

namespace HW09 {
    public class EmployeeData {
        public string ParseName(string email) {
            string[] emailArray = email.Split('@');
            string name = emailArray[0];
            
            string[] nameArray = name.Split('.');
            
            string firstName = FirstToUpper(nameArray[0]);
            string lastName = FirstToUpper(nameArray[1]);

            firstName = NameToCorrectFormat(firstName, '-', ' ');
            lastName = NameToCorrectFormat(lastName, '_', '-');

            return $"{firstName} {lastName}";
        }

        private string NameToCorrectFormat(string name, char initChar, char resultChar) {
            if (name.Length >= 2) {
                if (name.Contains(initChar.ToString())) {
                    string[] nameArray = name.Split(initChar);
                    List<string> names = new List<string>();

                    foreach (string nameInArray in nameArray) {
                        names.Add(nameInArray);
                    }

                    name = string.Join(resultChar.ToString(), names);
                }
            } else name = "Unknown";

            return name;
        }

        private string FirstToUpper(string input) {
            string firstLetter = input[0].ToString().ToUpper();
            return firstLetter + input.Remove(0, 1);
        }
    }
}