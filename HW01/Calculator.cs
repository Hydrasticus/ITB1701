using System;

namespace HW01 {
    class Calculator {
        static void Main(string[] args) {
            double a, b, sum, subtract, multiply, divide;

            Console.WriteLine("See on nüüd selline imelik kalkulaator, mis oskab kahe arvuga igasuguseid vigureid teha:" +
                              "\nsummat, vahet, korrutist ja jagatist arvutada ning lõpuks summast ruutjuurt võtta.");
            Console.Write("\nSisesta esimene arv: ");
            a = Double.Parse(Console.ReadLine());

            Console.Write("Sisesta teine arv: ");
            b = Double.Parse(Console.ReadLine());

            sum = a + b;
            Console.WriteLine("\nKahe arvu summa on: " + sum + 
                              "\nVajuta 'Enter', et kahe arvu vahe leida.");
            Console.ReadLine();

            subtract = a - b;
            Console.WriteLine("Kahe arvu vahe on: " + subtract +
                              "\nVajuta 'Enter', et kahe arvu korrutis leida.");
            Console.ReadLine();

            multiply = a * b;
            Console.WriteLine("Kahe arvu korrutis on: " + multiply +
                              "\nVajuta 'Enter', et kahe arvu jagatis leida.");
            Console.ReadLine();

            divide = a / b;
            Console.WriteLine("Kahe arvu jagatis on: " + divide + 
                              "\nVajuta 'Enter', et kahe arvu summast ruutjuur võtta.");
            Console.ReadLine();
            
            double sqrt = Math.Sqrt(sum);
            if (sum < 0) {
                Console.WriteLine("Negatiivsest arvust ei saa ruutjuurt võtta!");
            } else {
                Console.WriteLine("Ruutjuur summast on: " + sqrt);
            }

            Console.WriteLine("\nVajuta 'Enter', et rakendusest väljuda.");
            Console.ReadLine();
        }
    }
}
