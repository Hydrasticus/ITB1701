using System;

namespace HW04 {
    internal class Program {
        public static void Main(string[] args) {
            IdCode idCode = new IdCode();
            //idCode.SetIdCard(39603066818);
            
            //idCode.DecodeId();
            Console.WriteLine(idCode.EncodeId("naine", "08/06/1885", "Tapa"));
            
            Console.ReadLine();
        }
    }
}