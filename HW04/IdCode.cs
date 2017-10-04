using System;
using System.Collections.Generic;
using System.IO;

namespace HW04 {
    public class IdCode {
        private string _id, _sex, _birthDate, _birthArea;
        private int _birthCode, _controlNumber;
        private readonly DateTime _invalidYear = new DateTime(2013, 1, 1);
        private string _readPath = "id_codes.txt";
        private string _writePath = "information.txt";

        public IdCode() {
        }

        public IdCode(long id) {
            if (id.ToString().Length != 11) {
                Console.WriteLine("Invalid ID code!");
            } else
                _id = id.ToString();
        }

        public IdCode(string id) {
            if (id.Length != 11) {
                Console.WriteLine("Invalid ID code!");
            } else
                _id = id;
        }
        
        public void SetIdCode(long id) {
            if (id.ToString().Length != 11) {
                Console.WriteLine("Invalid ID code!");
            } else
                _id = id.ToString();
        }
        
        public void SetIdCode(string id) {
            if (id.Length != 11) {
                Console.WriteLine("Invalid ID code!");
            } else
                _id = id;
        }
        
        // Method to print out information from the ID code.
        public void PrintInfoFromId() {
            if (_id == null) {
                Console.WriteLine("Set an ID code first!");
            } else {
                DecodeId();
        
                Console.WriteLine("Isik isikukoodiga {0} on sündinud {1}. Ta on {2}, " +
                                  "kelle isikukoodi registreerimiskoht oli {3}. " +
                                  "Isikukoodi kontrollnumbriks on {4}.",
                    _id, _birthDate, _sex, _birthArea, _controlNumber);
            }
        }

        // Method for reading ID codes from a file and adding them into a list.
        public List<string> ReadIdFromFile() {
            List<string> listOfIdCodes = new List<string>();

            using (StreamReader reader = new StreamReader(_readPath)) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    listOfIdCodes.Add(line);
                }
            }
                
            Console.WriteLine("Loaded {0} ID codes from {1}.\n", listOfIdCodes.Count, _readPath);
            return listOfIdCodes;
        }
        
        // Method to parse out information from the ID code.
        private void DecodeId() {
            // Determines sex.
            int sex = int.Parse(_id.Substring(0, 1));
            _sex = sex % 2 == 0 ? "naine" : "mees";

            // Determines the first half of the birth year.
            string birthYearFirstHalf;
            if (sex == 1 || sex == 2) {
                birthYearFirstHalf = "18";
            } else if (sex == 3 || sex == 4) {
                birthYearFirstHalf = "19";
            } else {
                birthYearFirstHalf = "20";
            }

            // Takes the second half of the birth year from the ID, appends it to the first half.
            string birthYearSecondHalf = _id.Substring(1, 2);
            string birthYear = birthYearFirstHalf + birthYearSecondHalf;

            //Determines the month and day of birth.
            string birthMonth = _id.Substring(3, 2);
            string birthDay = _id.Substring(5, 2);

            // Sets the birth date.
            _birthDate = new DateTime(int.Parse(birthYear),
                int.Parse(birthMonth), int.Parse(birthDay)).ToShortDateString();

            // Runs the method to determine the birth place according to the ID.
            _birthCode = int.Parse(_id.Substring(7, 3));
            GetBirthPlace(_birthCode);
            
            // Takes the control number from the ID.
            _controlNumber = Int32.Parse(_id.Substring(10, 1));
        }

        // Method for saving information taken from an ID code to a file.
        public void SaveIdInfoToFile() {
            if (_id == null) {
                Console.WriteLine("Set an ID code first!");
            } else {
                DecodeId();
    
                using (StreamWriter writer = new StreamWriter(_writePath, true)) {
                    writer.WriteLine("ID code: {0}; sex: {1}; date of birth: {2}; place of birth: {3}.",
                        _id, _sex, _birthDate, _birthArea);
                }
                
                Console.WriteLine("Saved information from ID {0} to {1}.\n", _id, _writePath);
            }
        }
        
        // Method to create an ID code using a person's sex, birth date and the area the person's birth was registered.
        public void EncodeId(string sex, string birthDate, string birthArea) {
            string idString = "";

            int birthYear = int.Parse(birthDate.Substring(6, 4));
            
            // First number
            if (birthYear >= 1800 && birthYear <= 1899) {
                idString += (sex == "mees" ? 1 : 2);
            } else if (birthYear >= 1900 && birthYear <= 1999) {
                idString += (sex == "mees" ? 3 : 4);
            } else if (birthYear >= 2000 && birthYear <= 2099) {
                idString += (sex == "mees" ? 5 : 6);
            }
            
            // Second and third numbers
            idString += birthDate.Substring(8, 2);
            
            // Fourth and fifth numbers
            idString += birthDate.Substring(3, 2);
            
            // Sixth and seventh numbers
            idString += birthDate.Substring(0, 2);
            
            // Eighth to tenth numbers
            idString += GetBirthCode(birthArea);
            
            // Eleventh number
            idString += SetControlNumber(idString);
            
            Console.WriteLine(idString);
            _id = idString;
        }
        
        // Method to determine the birth place using the code from ID.
        private void GetBirthPlace(int birthCode) {
            if (DateTime.Parse(_birthDate) < _invalidYear) {
                switch (birthCode) {
                    case int i when (i >= 1 && i <= 10):
                        _birthArea = "Kuressaare Haigla";
                        break;
                    case int i when (i >= 11 && i <= 19):
                        _birthArea = "Tartu Ülikooli Naistekliinik/Tartumaa/Tartu";
                        break;
                    case int i when (i >= 21 && i <= 220):
                        _birthArea =
                            "Ida-Tallinna Keskhaigla/Pelgulinna sünnitusmaja/Hiiumaa/Keila/Rapla haigla/Loksa haigla";
                        break;
                    case int i when (i >= 221 && i <= 270):
                        _birthArea = "Ida-Viru Keskhaigla (Kohtla-Järve, endine Jõhvi)";
                        break;
                    case int i when (i >= 271 && i <= 370):
                        _birthArea = "Maarjamõisa Kliinikum (Tartu)/Jõgeva Haigla";
                        break;
                    case int i when (i >= 371 && i <= 420):
                        _birthArea = "Narva Haigla";
                        break;
                    case int i when (i >= 421 && i <= 470):
                        _birthArea = "Pärnu Haigla";
                        break;
                    case int i when (i >= 471 && i <= 490):
                        _birthArea = "Pelgulinna Sünnitusmaja (Tallinn)/Haapsalu haigla";
                        break;
                    case int i when (i >= 491 && i <= 520):
                        _birthArea = "Järvamaa Haigla (Paide)";
                        break;
                    case int i when (i >= 521 && i <= 570):
                        _birthArea = "Rakvere/Tapa haigla";
                        break;
                    case int i when (i >= 571 && i <= 600):
                        _birthArea = "Valga Haigla";
                        break;
                    case int i when (i >= 601 && i <= 650):
                        _birthArea = "Viljandi Haigla";
                        break;
                    case int i when (i >= 651 && i <= 710):
                        _birthArea = "Lõuna-Eesti Haigla (Võru)/Põlva Haigla";
                        break;
                    default:
                        _birthArea = "teadmata haigla";
                        break;
                }
            } else
                _birthArea = "teadmata haigla";
        }

        // Method to determine the code in ID that corresponds to the birth place.
        private static string GetBirthCode(string birthArea) {
            int area;
            Random random = new Random();
            
            if (birthArea.Contains("Kuressaare")) {
                area = random.Next(1, 10);
            } else if (birthArea.Contains("Tartu")) {
                area = random.Next(11, 19);
            } else if (birthArea.Contains("Ida-Tallinn") || birthArea.Contains("Pelgulinn") ||
                       birthArea.Contains("Hiiumaa") || birthArea.Contains("Keila") || 
                       birthArea.Contains("Rapla") || birthArea.Contains("Loksa")) {
                area = random.Next(21, 220);
            } else if (birthArea.Contains("Ida-Viru")) {
                area = random.Next(221, 270);
            } else if (birthArea.Contains("Maarjamõisa") || birthArea.Contains("Jõgeva")) {
                area = random.Next(271, 370);
            } else if (birthArea.Contains("Narva")) {
                area = random.Next(371, 420);
            } else if (birthArea.Contains("Pärnu")) {
                area = random.Next(421, 470);
            } else if (birthArea.Contains("Haapsalu")) {
                area = random.Next(471, 490);
            } else if (birthArea.Contains("Järvamaa")) {
                area = random.Next(491, 520);
            } else if (birthArea.Contains("Rakvere") || birthArea.Contains("Tapa")) {
                area = random.Next(521, 570);
            } else if (birthArea.Contains("Valga")) {
                area = random.Next(571, 600);
            } else if (birthArea.Contains("Viljandi")) {
                area = random.Next(601, 650);
            } else if (birthArea.Contains("Võru") || birthArea.Contains("Põlva")) {
                area = random.Next(651, 670);
            } else area = random.Next(671, 999);

            return area.ToString();
        }

        // Method to set the last digit of the ID code using the previously set 10 digits.
        private static int SetControlNumber(string id) {
            // Converts the id string to a list of integers.
            List<int> idNumbers = new List<int>();
            foreach (char c in id) {
                idNumbers.Add((int)Char.GetNumericValue(c));
            }
            
            // Creates the first module of numbers.
            string module1 = "1234567891";
            List<int> module1Numbers = new List<int>();
            foreach (char c in module1) {
                module1Numbers.Add((int)Char.GetNumericValue(c));
            }
            
            // Creates the second module.
            string module2 = "3456789123";
            List<int> module2Numbers = new List<int>();
            foreach (char c in module2) {
                module2Numbers.Add((int)Char.GetNumericValue(c));
            }
            
            int numberToCheck = 0;

            // Creates the first control number using the first module.
            for (int i = 0; i < module1Numbers.Count; i++) {
                numberToCheck += module1Numbers[i] * idNumbers[i];
            }
            numberToCheck = numberToCheck % 11;
            
            // Checks the control number against the invalid remainder, in case they are equal,
            // recreates the control number with the second module. If the condition remains true 
            // for the second number, sets the control number to zero.
            if (numberToCheck == 10) {
                numberToCheck = 0;
                for (int i = 0; i < module2Numbers.Count; i++) {
                    numberToCheck += module2Numbers[i] * idNumbers[i];
                }
                numberToCheck = numberToCheck % 11;
                
                if (numberToCheck == 10) {
                    numberToCheck = 0;
                }
            }
            
            return numberToCheck;
        }
    }
}