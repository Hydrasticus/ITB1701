using System;

namespace HW03 {
    public class BankCard {
        private double _balance;
        private string _cardType;
        private int _cardNumber;

        public BankCard() {
            _balance = 0;
            _cardType = "Visa";
        }

        public BankCard(int balance, string cardType) {
            _balance = balance;
            _cardType = cardType;
        }

        public void SetCardNumber(string cardNumber) {
            if (cardNumber.Length != 8) {
                Console.WriteLine("Invalid value, the correct format is 8 digits!\n");
            } else {
                _cardNumber = int.Parse(cardNumber);
                Console.WriteLine("The card number is: {0}\n", _cardNumber);
            }
        }

        public void PrintCardType() {
            Console.WriteLine("The card type is: {0}\n", _cardType);
        }

        public void PrintBalance() {
            Console.WriteLine("Your balance is: {0}\n", _balance);
        }

        public void IncreaseBalance(double deposit) {
            _balance += deposit;
            Console.WriteLine("You have successfully deposited {0}" +
                              "\nYour balance is: {1}\n", deposit, _balance);
        }

        public void DecreaseBalance(double withdraw) {
            double endBalance = _balance -= withdraw;

            if (endBalance < 0) {
                Console.WriteLine("Cannot do this operation, insufficient funds!\n");
            } else {
                _balance = endBalance;
                Console.WriteLine("You have successully withdrawn {0}" +
                                  "\nYour balance is: {1}\n", withdraw, _balance);
            }
        }
    }
}