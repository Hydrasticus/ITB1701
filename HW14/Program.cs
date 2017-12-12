using System;
using System.Collections.Generic;

namespace HW14 {
    internal class Program {
        public static void Main(string[] args) {
            StringManipulator strMani = new StringManipulator();
            //strMani.DecodeAccount("ttu\\mari.maasikas"); // Name: Mari Maasikas, Domain: TTU

            string input = "sitt";
            char firstChar = input[0];
            firstChar = char.ToUpper(firstChar);
            input.Replace(input[0], firstChar);
            
            Console.WriteLine(input);
        }
    }
}