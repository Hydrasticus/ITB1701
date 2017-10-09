using System;
using System.Collections.Generic;
using System.ComponentModel;
using static PR06.Program;

namespace PR06 {
    public class TestClass {
        class Program {
            public static void Main(string[] args) {
                // Class inheritance: Exercise 5
                DebitCard dCard = new DebitCard("debit");
                
                dCard.SetBalance(800);
                dCard.MakePayment(900); // Can't make this payment
                dCard.MakePayment(700);
                dCard.PrintCardInfo();
                dCard.CloseCard();
                dCard.PrintCardInfo();
                
                CreditCard cCard = new CreditCard("credit", -500);
                cCard.OpenCard();
                cCard.MakePayment(600); // Can't make this payment
                cCard.MakePayment(400);
                cCard.CloseCard();
                cCard.PrintCardInfo();
                
                // Class inheritance: Exercise 4
                Shape[] shapes = new Shape[3];
                shapes[0] = new Circle();
                shapes[1] = new Square();
                shapes[2] = new Triangle();

                foreach (Shape shape in shapes) {
                    shape.Draw();
                }
                
                List<Shape> shapeList = new List<Shape>();
                shapeList.Add(new Circle());
                shapeList.Add(new Square());
                shapeList.Add(new Triangle());

                foreach (Shape shape in shapeList) {
                    shape.Draw();
                }
                
                // Class inheritance: Exercise 2
                ChildClass myChild = new ChildClass();
                myChild.print();
                
                ParentClass parent = new ParentClass();
                parent.print();
                
                // Interface
                Dog myDog = new Dog();
                myDog.Travel("space");
                myDog.Eat("a carrot");
                
                Rabbit myRabbit = new Rabbit();
                myRabbit.Travel("Tartu");
                myRabbit.Eat("a horse");
                
                Console.ReadLine();
            }
        }
    }
}