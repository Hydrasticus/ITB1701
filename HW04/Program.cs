using System;

namespace HW04 {
    internal class Program {
        public static void Main(string[] args) {
            IdCard idCard = new IdCard();
            idCard.SetIdCard(39603066818);
            
            idCard.DecodeId();
            Console.WriteLine(idCard.SetControlNumber());
            
            Console.ReadLine();
        }
    }
}