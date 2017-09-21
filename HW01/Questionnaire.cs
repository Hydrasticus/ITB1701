using System;

namespace HW01 {
    class Questionnaire {
        static void Main(string[] args) {
            int correctAnswers = 0;

            Console.Write("Tere tulemast Onu Alo küsimustikku vastama!" +
                          "\n1. Milline neist vulkaanidest purskas 2010. aastal? Vesuuv, Yellowstone või Eyjafjallajökull?" +
                          "\nVastus: ");
            string firstAnswer = Console.ReadLine();
            string firstCorrect = "Eyjafjallajökull";

            if (firstAnswer == firstCorrect) {
                correctAnswers++;
            }

            Console.Write("2. Mitu stuudioalbumit on Led Zeppelin oma karjääri jooksul väljastanud? 9, 11 või 13?" +
                          "\nVastus: ");
            int secondAnswer = Int32.Parse(Console.ReadLine());
            int secondCorrect = 9;

            if (secondAnswer == secondCorrect) {
                correctAnswers++;
            }

            Console.Write("3. Mis on Euleri arvu ligikaudne väärtus? 2.718, 3.142 või 1.337?" +
                          "\nVastus: ");
            double thirdAnswer = Double.Parse(Console.ReadLine());
            double thirdCorrect = 2.718;

            if (thirdAnswer == thirdCorrect) {
                correctAnswers++;
            }

            Console.WriteLine("\nOled õigesti vastanud " + correctAnswers + " küsimust.");
            if (correctAnswers == 3) {
                Console.WriteLine("Hästi tehtud! Kõik vastused on õiged!");
            } else {
                Console.WriteLine("Kahjuks ei olnud kõik vastused õiged. Proovi uuesti!");
            }

            Console.WriteLine("\nVajuta 'Enter', et väljuda rakendusest.");
            Console.ReadLine();
        }
    }
}