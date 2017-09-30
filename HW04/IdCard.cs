using System;

namespace HW04 {
    public class IdCard {
        private string _id;
        private string _sex;
        private string _date;
        private int _birthCode;
        private string _birthArea;
        private int _controlNumber;
        
        public IdCard() {
        }

        public IdCard(string id) {
        }

        public void DecodeId(string id) {
            _id = id;

            int sex = Int32.Parse(id.Substring(0, 1));
            _sex = sex % 2 == 0 ? "naine" : "mees";

            string birthYearFirstHalf;
            if (sex == 1 || sex == 2) {
                birthYearFirstHalf = "18";
            } else if (sex == 3 || sex == 4) {
                birthYearFirstHalf = "19";
            } else {
                birthYearFirstHalf = "20";
            }
            
            string birthYearSecondHalf = id.Substring(1, 2);
            string birthYear = birthYearFirstHalf + birthYearSecondHalf;
            string birthMonth = id.Substring(3, 2);
            string birthDay = id.Substring(5, 2);
            
            DateTime date = new DateTime(Int32.Parse(birthYear), 
                Int32.Parse(birthMonth), Int32.Parse(birthDay));
            _date = date.ToShortDateString();
            
            _birthCode = Int32.Parse(id.Substring(7, 3));
            _controlNumber = Int32.Parse(id.Substring(10, 1));
            
            Console.WriteLine("Isik isikukoodiga {0} on sündinud {1}. Ta on {2}, " +
                              "kelle isikukood registreeriti {3} haiglas ja sel päeval oli ta {4} {5}. " +
                              "Isikukoodi kontrollnumbriks on {6}.",
                _id, _date, _sex, _birthCode, _controlNumber, _controlNumber, _controlNumber);
        }

        public void GetBirthPlace() {
            switch (_birthCode) {
                    case int i when (i >= 1 && i <= 10):
                        _birthArea = "Kuressaare";
                        break;
            }
        }
    }
}