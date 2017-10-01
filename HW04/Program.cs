using System;
using System.Collections.Generic;

namespace HW04 {
    internal class Program {
        public static void Main(string[] args) {
            IdCode idCode = new IdCode();
            //idCode.SetIdCard(39603066818);
            
            //idCode.DecodeId();
            
            List<int> idNumbers = new List<int>();
            idNumbers.Add(3);
            idNumbers.Add(96);
            idNumbers.Add(12);
            idNumbers.Add(10);
            idNumbers.Add(555);
            
            Console.WriteLine(idNumbers); //System.Collections.Generic.List`1[System.Int32]
            
            //Console.WriteLine(idCode.EncodeId("mees", "10.12.1996", "Tapa").ToString());
            
            Console.ReadLine();
        }
    }
}