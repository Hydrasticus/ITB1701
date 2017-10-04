using System;
using System.Collections.Generic;

namespace HW04 {
    internal class Program {
        public static void Main(string[] args) {
            IdCode idOne = new IdCode();
            //idOne.SetIdCode("22212099821");
            
            IdCode idTwo = new IdCode(22212099821);
            IdCode idThree = new IdCode("50005265314");
            
            //idOne.EncodeId("naine", "12.05.2005", "Tartu"); // Threw some kind of error.
            
            List<string> idCodes = idOne.ReadIdFromFile();
            foreach (string s in idCodes) {
                Console.WriteLine(s);
            }
            
            Console.ReadLine();
        }
    }
}