using System;
using HW03;

namespace EX03 {
    public class Program {
        public static void Main(string[] args) {
            BankCard bankCard1 = new BankCard();
            BankCard bankCard2 = new BankCard(200, "Maestro");
            
            bankCard1.SetCardNumber("12345678");
            bankCard2.SetCardNumber("42");
            
            bankCard1.IncreaseBalance(75.52);
            bankCard1.PrintBalance();
            
            bankCard1.DecreaseBalance(54.99);
            bankCard2.DecreaseBalance(252);

            Console.ReadLine();
        }
    }
}