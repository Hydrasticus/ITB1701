using System.Collections.Generic;

namespace HW09 {
    public class EmployeeData {
        public string ParseData(string input) {
            string[] inputArray = input.Split('@');
            string name = inputArray[0];

            string[] nameArray = name.Split('.');
            string firstName = nameArray[0];
            string lastName = nameArray[1];

            if (firstName.Contains("-")) {
                string[] firstNameArray = firstName.Split('-');
                List<string> firstNames = new List<string>();
                foreach (string nameInArray in firstNameArray) {
                    firstNames.Add(nameInArray);
                }
                firstName = string.Join(" ", firstNames);
            }

            if (lastName.Contains("_")) {
                string[] lastNameArray = lastName.Split('_');
                List<string> lastNames = new List<string>();
                foreach (string nameInArray in lastNameArray) {
                    lastNames.Add(nameInArray);
                }
                lastName = string.Join("-", lastNames);
            }
            
            return $"{firstName} {lastName}";
        }
    }
}