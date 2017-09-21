using System;

namespace PR03 {
    class TestingClass {
        static void Main(string[] args) {
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.DepositCoin(75);
            vendingMachine.GetDrink();
            vendingMachine.GetRefund();
            Console.WriteLine();

            vendingMachine.DepositCoin(80);
            vendingMachine.GetDrink();
            vendingMachine.GetRefund();
            Console.WriteLine();
            
            vendingMachine.DepositCoin(60);
            vendingMachine.GetDrink();
            vendingMachine.DepositCoin(20);
            vendingMachine.GetDrink();
            vendingMachine.GetRefund();
            Console.WriteLine();
            
            vendingMachine.DepositCoin(-42);
            vendingMachine.GetDrink();
            vendingMachine.GetRefund();
            Console.WriteLine();

            vendingMachine.GetDrink();
            vendingMachine.GetRefund();
            Console.WriteLine();

            /*
            Person person1 = new Person();
            Console.WriteLine(person1.GetName());
            
            Person person2 = new Person("Mary Jones");
            Console.WriteLine(person2.GetName());
            
            Person person3 = new Person("Aita-Leida Kuusepuu", 69);
            Console.WriteLine(person3.GetName());
            Console.WriteLine(person3.GetAge());
            */
            
            /*
            person1.SetAge("89");
            Console.WriteLine(person1.GetAge());
            
            person1.SetAge("1989");
            Console.WriteLine(person1.GetAge());

            person1.SetAge("19898885");
            Console.WriteLine(person1.GetAge());

            person2.SetName("Eino Muidugi");
            person2.SetAge(new DateTime(2000, 1, 1));
            
            Console.WriteLine(person1.GetName());
            Console.WriteLine(person1.GetAge());
            
            Console.WriteLine(person2.GetName());
            Console.WriteLine(person2.GetAge());
            */
            
            /*
            HelloWorldPrinter myPrinter = new HelloWorldPrinter();
            myPrinter.PrintText();
            */
            
            Console.ReadLine();
        }
    }
}