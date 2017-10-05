using System;
using System.Collections.Generic;

namespace HW04 {
    internal class Program {
        public static void Main(string[] args) {
            IdCode idOne = new IdCode();
            idOne.PrintInfoFromId();
            idOne.SetIdCode("22212099821");
            
            IdCode idTwo = new IdCode(22212099821);
            idTwo.PrintInfoFromId();
            idTwo.ReadIdFromFile();
            
            IdCode idThree = new IdCode("50005265314");
            
            idThree.EncodeId("mees", "10.07.2010", "Kärdla");
            idThree.EncodeId("naine", "24.08.1988", "Haapsalu");
            idThree.EncodeId("mees", "02.03.2000", "Järvamaa");
            idThree.EncodeId("naine", "16.06.1994", "Pelgulinn");
                        
            List<string> idCodes = idOne.ReadIdFromFile();
            foreach (string s in idCodes) {
                Console.WriteLine("ID: {0}", s);
            }
            
            idThree.SaveIdInfoToFile();
            
            Console.ReadLine();
        }
    }
}