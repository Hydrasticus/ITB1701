using System;
using System.Collections.Generic;

namespace HW04 {
    public class IdCode {
        private string _id, _sex, _birthDateString, _birthArea;
        private DateTime _birthDate;
        private readonly DateTime _invalidYear = new DateTime(2013, 1, 1);
        private int _birthCode, _controlNumber;
        private const int INVALID_REMAINDER = 10;
        //private string _readPath = "id.txt";
        //private string _writePath = "info.txt";
        
        public void SetIdCard(long id) {
            _id = id.ToString();
        }
        
        public void SetIdCard(string id) {
            _id = id;
        }
        
        public void DecodeId() {
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
                int.Parse(birthMonth), int.Parse(birthDay));
            _birthDateString = _birthDate.ToShortDateString();
            
            // Takes the control number from the ID.
            _controlNumber = Int32.Parse(_id.Substring(10, 1));
            
            // Runs the method to determine the birth place according to the ID.
            _birthCode = int.Parse(_id.Substring(7, 3));
            GetBirthPlace(_birthCode);
            
            Console.WriteLine("Isik isikukoodiga {0} on sündinud {1}. Ta on {2}, " +
                "kelle isikukoodi registreerimiskoht oli {3}. " +
                "Isikukoodi kontrollnumbriks on {4}.",
                _id, _birthDateString, _sex, _birthArea, _controlNumber);
        }

        public List<int> EncodeId(string sex, string birthDate, string birthArea) {
            List<int> idCode = new List<int>();

            int birthYear = DateTime.Parse(birthDate).Year;
            
            // First number
            if (birthYear >= 1800 && birthYear <= 1899) {
                idCode.Add(sex == "mees" ? 1 : 2);
            } else if (birthYear >= 1900 && birthYear <= 1999) {
                idCode.Add(sex == "mees" ? 3 : 4);
            } else if (birthYear >= 2000 && birthYear <= 2099) {
                idCode.Add(sex == "mees" ? 5 : 6);
            }

            // Second and third numbers
            idCode.Add(int.Parse(birthYear.ToString().Substring(2, 2)));
            
            // Fourth and fifth numbers
            int birthMonth = DateTime.Parse(birthDate).Month;
            idCode.Add(birthMonth);
            
            // Sixth and seventh numbers
            int birthDay = DateTime.Parse(birthDate).Day;
            idCode.Add(birthDay);
            
            // Eighth to tenth numbers
            idCode.Add(GetBirthCode(birthArea));

            // Eleventh number
            idCode.Add(SetControlNumber(idCode.ToString()));
            
            return idCode;
        }
        
        private void GetBirthPlace(int birthCode) {
            if (_birthDate < _invalidYear) {
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
            } else _birthArea = "teadmata haigla";
        }

        private int GetBirthCode(string birthArea) {
            Random random = new Random();
            int area = 0;
            
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

            return area;
        }

        private int SetControlNumber(string id) {
            // Creates the first module of numbers.
            List<int> module1 = new List<int>();
            for (int i = 1; i <= 9; i++) {
                module1.Add(i);
            }
            module1.Add(1);
            
            // Creates the second module.
            List<int> module2 = new List<int>();
            for (int i = 3; i <= 9; i++) {
                module2.Add(i);
            }
            module2.Add(1);
            module2.Add(2);
            module2.Add(3);
            
            // Converts the id code to a list of integers.
            // REDO!
            char[] idCode = id.ToCharArray();
            List<int> idNumbers = new List<int>();
            foreach (char c in idCode) {
                idNumbers.Add(int.Parse(c.ToString()));
            }
            
            int numberToCheck = 0;

            // Creates the first control number using the first module.
            for (int i = 0; i < module1.Count; i++) {
                numberToCheck += module1[i] * idNumbers[i];
            }
            numberToCheck = numberToCheck % id.Length;
            
            // Checks the control number against the invalid remainder, in case they are equal,
            // creates it with the second module. If the condition remains true for the second number,
            // sets the control number to zero.
            if (numberToCheck == INVALID_REMAINDER) {
                numberToCheck = 0;
                for (int i = 0; i < module2.Count; i++) {
                    numberToCheck += module2[i] * idNumbers[i];
                }
                numberToCheck = numberToCheck % id.Length;
                
                if (numberToCheck == INVALID_REMAINDER) {
                    numberToCheck = 0;
                }
            }
            
            return numberToCheck;
        }
    }
}