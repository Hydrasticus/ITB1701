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
                
            }
            
            return $"{firstName} {lastName}";
        }
    }
}