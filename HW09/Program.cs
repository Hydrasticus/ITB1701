using System;
using System.Collections.Generic;

namespace HW09 {
    internal class Program {
        public static void Main(string[] args) {
            Exercises exercise = new Exercises();
            Console.WriteLine(exercise.ReplaceSpace("Fuck  Your      Nice      Day"));
            
            TimeCalculator calc = new TimeCalculator();
            Console.WriteLine(calc.FindTime(+2));
            Console.WriteLine(calc.FindTime(-1));
            Console.WriteLine(calc.FindTime(+25.5));
            
            Console.WriteLine(calc.AddDay(2));
            Console.WriteLine(calc.AddDay(1));

            Console.WriteLine(calc.SubtractDay(5));
            Console.WriteLine(calc.SubtractDay(10));
        }
    }
}