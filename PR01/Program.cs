using System;

namespace PR01 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Mitu hammast on inimesel? 16, 32 või 48?");
            int a = Int32.Parse(Console.ReadLine());
            int rightAnswer = 32;
            int numberOfCorrectAnswers = 0;
            if (a == rightAnswer) {
                Console.WriteLine("Hästi paned.");
                numberOfCorrectAnswers++;
            } else {
                Console.WriteLine("Kindlasti mitte.");
            }
            Console.WriteLine("Oled õigesti vastanud " + numberOfCorrectAnswers + " küsimust.");
            Console.ReadLine();

            /*
            Console.WriteLine("Sisesta arv.");
            int a = Int32.Parse(Console.ReadLine());
            if (a > 10) {
                Console.WriteLine("Arv on väiksem kui 10.");
            } else if (a == 10) {
                Console.WriteLine("Arv on võrdne 10-ga.");
            } else {
                Console.WriteLine("Arv on suurem kui 10.");
            }
            Console.ReadLine();
            */

            /*
            bool a = 8 > 7;
            int t = 5;
            int f = 10;
            bool b = (2 + 3) == 5;
            Console.WriteLine(f/t==2);
            Console.WriteLine(b);
            Console.ReadLine();
            */

            /*
            double a;
            double b;
            double sum;
            double subtraction;
            double multiplication;
            double division;

            string firstNumber;
            string secondNumber;
            */

            /*
            Console.WriteLine("Wanna know how much is a + b? Enter the first number.");
            //firstNumber = Console.ReadLine();
            //Loeme sisse stringi ja siis teisendame int-tüüpi täisarvuks
            a = Int32.Parse(firstNumber);
            Console.WriteLine("Enter the second number.");
            //secondNumber = Console.ReadLine();
            b = Int32.Parse(secondNumber);
            sum = a + b;
            Console.WriteLine("The sum total of the two numbers is " + sum + ".");
            */

            /*
            Console.WriteLine("Let's subtract some shit! Enter the first number.");
            firstNumber = Console.ReadLine();
            a = Int32.Parse(firstNumber);
            Console.WriteLine("Enter the second number.");
            secondNumber = Console.ReadLine();
            b = Int32.Parse(secondNumber);
            subtraction = a - b;
            Console.WriteLine("The first number minus second number equals " + subtraction + ".");
            */

            /*
            Console.WriteLine("Let's try multiplication. Enter the first number.");
            firstNumber = Console.ReadLine();
            a = Double.Parse(firstNumber);
            Console.WriteLine("Enter the second number.");
            secondNumber = Console.ReadLine();
            b = Double.Parse(secondNumber);
            multiplication = a * b;
            Console.WriteLine("The answer is " + multiplication + ".");
            Console.ReadLine();
            */

            /*
            Console.WriteLine("Division. Enter the first number.");
            firstNumber = Console.ReadLine();
            a = Int32.Parse(firstNumber);
            Console.WriteLine("Enter the second number.");
            secondNumber = Console.ReadLine();
            b = Int32.Parse(secondNumber);
            division = (double)a / (double)b;
            Console.WriteLine("The answer is " + division + ".");
            Console.ReadLine();
            */

            /*
            string name;
            string age;
            string watdo;
          
            Console.Write("Palun sisesta oma nimi: ");
            name = Console.ReadLine();
            Console.WriteLine("Vana oled?");
            age = Console.ReadLine();
            Console.WriteLine("Mis teed siin?");
            watdo = Console.ReadLine();
            Console.WriteLine("Tere, minu nimi on " + name + ", olen " + age + " aastat vana ja " + watdo + ".");
            Console.ReadLine();
            */

            //MINU OMA PASK.
            /*
            Console.WriteLine("Kirjuta siia oma nimi: ");
            string name = Console.ReadLine();
            Console.WriteLine("Tere, " + name);
            Console.ReadLine();

            Console.Write("Sisesta esimene number: ");
            string firstNumber = Console.ReadLine();
            Console.Write("Sisesta teine number: ");
            string secondNumber = Console.ReadLine();
            int sum = Convert.ToInt32(firstNumber) + Convert.ToInt32(secondNumber);
            Console.WriteLine(sum);
            Console.ReadLine();

            Console.Write("Sisesta number vahemikus 1 kuni 10: ");
            string number1to10 = Console.ReadLine();
            int number = Convert.ToInt32(number1to10);
            if (number > 1 && number < 10) {
                Console.WriteLine("Tubli, oskad lugeda!");
            }
            else Console.WriteLine("Mida ma just ütlesin?");
            Console.ReadLine();
            */
        }
    }
}
