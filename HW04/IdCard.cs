using System;
using System.Collections.Generic;
using Microsoft.SqlServer.Server;

namespace HW04 {
    public class IdCard {
        private int _sex;
        private DateTime _date;
        private int _birthPlace;
        private int _controlNumber;
        
        public IdCard() {
        }

        public IdCard(string id) {
        }

        public void DecodeId(string id) {
            string sex;
            string birthYearFirstHalf;

            _sex = Int32.Parse(id.Substring(0, 1));
            sex = _sex % 2 == 0 ? "naine" : "mees";

            if (_sex == 1 || _sex == 2) {
                birthYearFirstHalf = "18";
            } else if (_sex == 3 || _sex == 4) {
                birthYearFirstHalf = "19";
            } else {
                birthYearFirstHalf = "20";
            }
            
            string birthYearSecondHalf = id.Substring(1, 2);
            string birthYear = birthYearFirstHalf + birthYearSecondHalf;
            string birthMonth = id.Substring(3, 2);
            string birthDay = id.Substring(5, 2);
            _date = new DateTime(Int32.Parse(birthYear), Int32.Parse(birthMonth), Int32.Parse(birthDay));
            string date = _date.ToShortDateString();
            
            _birthPlace = Int32.Parse(id.Substring(7, 3));
            _controlNumber = Int32.Parse(id.Substring(10, 1));
            
            Console.WriteLine("Isik isikukoodiga {0} on sündinud {1}. Ta on {2}, " +
                              "kelle isikukood registreeriti {3} haiglas ja sel päeval oli ta {4} {5}. " +
                              "Isikukoodi kontrollnumbriks on {6}.",
                id, date, sex, _birthPlace, _controlNumber, _controlNumber, _controlNumber);
        }
    }
}