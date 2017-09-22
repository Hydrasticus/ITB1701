using System;
using System.Linq;

namespace PR03 {
    public class Lecture3 {
        public void Lecture() {
            int a = 5;
            bool notTrue = false;

            string b = WhatEven("Juhan", a).ToString();
            string c = ReverseString(b);
        }

        public int ReturnSumOfTwoInts(int a, int b) {
            return a + b;
        }

        public void Method(string a, string b) {
        }

        public bool WhatEven(string a, int b) {
            return true;
        }

        public double SumOfFourDoubles(double a, double b, double c, double d) {
            return a + b + c + d;
        }

        public string ReverseString(string a) {
            string b = a.Reverse().ToString();
            
            return b;
        }
    }

    public class Table {
        private int _width, _height;
        
        public Table(int width, int height) {
            _width = width;
            _height = height;
        }

        public void ShowData() {
            Console.WriteLine("The width of the table is: {0}, and the height: {1}", _width, _height);
        }
    }
}