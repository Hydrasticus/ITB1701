using System;
using System.Collections.Generic;

namespace PR06 {
    class Program {
        // Interface
        interface IAnimal {
            void Eat(string food);
            void Travel(string destination);
        }

        public class Dog : IAnimal {
            public void Travel(string destination) {
                Console.WriteLine("Dog travels to {0}", destination);
            }

            public void Eat(string food) {
                Console.WriteLine("Dog eats {0}", food);
            }
        }
        
        public class Rabbit : IAnimal {
            public void Travel(string destination) {
                Console.WriteLine("Rabbit goes to " + destination);
            }

            public void Eat(string food) {
                Console.WriteLine("Rabbit devours " + food);
            }
        }

        // Class inheritance: Exercise 2
        public class ParentClass {
            public ParentClass() {
                Console.WriteLine("Parent Constructor.");
            }
            
            public void print() {
                Console.WriteLine("I'm a parent class.");
            }
        }

        public class ChildClass : ParentClass {
            public ChildClass() {
                Console.WriteLine("Child Constructor.");
            }
        }
        
        // Class inheritance: Exercise 4
        interface IShape {
            void Draw();
        }

        public class Shape : IShape {
            public virtual void Draw() { // virtual means this method can be overwritten
                Console.WriteLine("I am a shape!");
            }
        }
        
        public class Circle : Shape {
            public override void Draw() { // overwrites base method
                base.Draw();
                Console.WriteLine("I am a circle!");
            }
        }
        
        public class Square : Shape {
            public override void Draw() {
                base.Draw();
                Console.WriteLine("I am a square!");
            }
        }
        
        public class Triangle : Shape {
            public override void Draw() {
                base.Draw();
                Console.WriteLine("I am a triangle!");
            }
        }
        
        // Class inheritacne: Exercise 5
        interface IBankCard {
            void GetBalance();
            void SetBalance(double value);
            void MakePayment(double payment);
            void PrintCardInfo();
            void CloseCard();
            void OpenCard();
        }

        public class DebitCard : IBankCard {
            internal double _balance;
            internal string _cardType;
            internal bool _isCardOpen;

            public DebitCard() {
                
            }
            
            public DebitCard(string cardType) {
                _balance = 0;
                _cardType = cardType;
                _isCardOpen = true;
            }
            
            public void GetBalance() {
                Console.WriteLine("Account balance: " + _balance);
            }
            
            public void SetBalance(double amount) {
                if (!_isCardOpen) {
                    Console.WriteLine("Cannot set account balance! Card is closed!");
                } else
                    _balance = amount;
            }
            
            public virtual void MakePayment(double payment) {
                if (!_isCardOpen) {
                    Console.WriteLine("Cannot process the payment! Card is closed!");
                } else if (payment < 0) {
                    Console.WriteLine("Payment cannot be negative!");
                } else {
                    if (payment > _balance) {
                        Console.WriteLine("Insufficient funds!");
                    } else {
                        _balance -= payment;
                    }
                }
            }
            
            public virtual void PrintCardInfo() {
                string info = String.Format("Card type: {0}, balance: {1}",
                    _cardType, _balance);
                
                if (!_isCardOpen) {
                    info += ", status: closed";
                }
                
                Console.WriteLine(info);
            }

            public void CloseCard() {
                if (!_isCardOpen) {
                    Console.WriteLine("The card is already closed!");
                } else
                    _isCardOpen = false;
            }

            public void OpenCard() {
                if (_isCardOpen) {
                    Console.WriteLine("The card is already open!");
                } else
                    _isCardOpen = true;
            }
        }

        public class CreditCard : DebitCard {
            private double _creditLimit;

            public CreditCard(string cardType, double creditLimit) {
                if (creditLimit >= 0) {
                    Console.WriteLine("The credit limit must be negative!");
                } else {
                    _balance = 0;
                    _cardType = cardType;
                    _creditLimit = creditLimit;
                    _isCardOpen = false;
                }
            }
            
            public override void MakePayment(double payment) {
                if (!_isCardOpen) {
                    Console.WriteLine("Cannot process the payment! Card is closed!");
                } else if (payment < 0) {
                    Console.WriteLine("Payment cannot be negative!");
                } else {
                    if ((_balance - payment) < _creditLimit) {
                        Console.WriteLine("Payment exceeds credit limit!");
                    } else {
                        _balance -= payment;
                    }
                }
            }

            public override void PrintCardInfo() {
                base.PrintCardInfo();
                Console.WriteLine("Credit limit: " + _creditLimit);
            }
        }
    }
}