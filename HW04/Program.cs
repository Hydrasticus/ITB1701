using System;

namespace HW04 {
    internal class Program {
        public static void Main(string[] args) {
            IdCard idCard = new IdCard();
            idCard.DecodeId("39603066818");
            
            Console.ReadLine();
        }
    }
}