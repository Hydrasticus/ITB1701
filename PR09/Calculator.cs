using System;

namespace PR09 {
    public class Calculator {
        public int Subtract(int a, int b) {
            return b > a ? b - a : a - b;
        }
        
        public double Subtract(double a, double b) {
            return b > a ? Math.Round(b - a, 2) : Math.Round(a - b, 2);
        }

        public int Multiply(int a, int b) {
            return a * b;
        }
        
        public double Multiply(double a, double b) {
            return Math.Round(a * b, 2);
        }

        public int Multiply(int a, int b, int c) {
            return a * b * c;
        }
        
        public double Multiply(double a, double b, double c) {
            return Math.Round(a * b * c, 2);
        }

        public int Square(int a) {
            return a * a;
        }

        public double Square(double a) {
            return Math.Round(a * a, 2);
        }
    }
}