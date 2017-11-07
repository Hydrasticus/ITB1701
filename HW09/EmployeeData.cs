namespace HW09 {
    public class EmployeeData {
        public string ParseData(string input) {
            string[] outputArray = input.Split('@');
            
            return string.Join(" ", outputArray);
        }
    }
}