using System.Linq;

namespace PR03 {
    public class Lecture3 {
        static void Lecture() {
            int a = 5;
            bool notTrue = false;

            string b = WhatEven("Juhan", a).ToString();
            string c = ReverseString(b);
        }

        static int ReturnSumOfTwoInts(int a, int b) {
            return a + b;
        }

        static void Method(string a, string b) {
        }

        static bool WhatEven(string a, int b) {
            return true;
        }

        static double SumOfFourDoubles(double a, double b, double c, double d) {
            return a + b + c + d;
        }

        static string ReverseString(string a) {
            string b = a.Reverse().ToString();
            
            return b;
        }
    }
}