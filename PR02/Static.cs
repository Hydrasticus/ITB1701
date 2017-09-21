using System;

namespace PR02 {
    class Static {
        static void Main(string[] args) {
            PrintString("Test");
            PrintSumOfInts(5, 6, 7, 8);

            int number = GetSumOfInts(4, 6);
            Console.WriteLine(number);

            bool a = StringContainsOtherString("Metskass", "Mets");
            bool b = StringContainsOtherString("Kana", "Mets");
            bool c = StringContainsOtherString("koolikohvik", "kohvik");

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.WriteLine(GetJoinedStrings("rõve ", "elukas"));
            string joined = GetJoinedStrings("return ", "method");
            Console.WriteLine(joined);

            PrintJoinedString("soul ", "sucker");

            Console.ReadLine();
        }
        public static void PrintString(string textToPrint) {
            Console.WriteLine(textToPrint);
        }
        public static void PrintSumOfInts(int a, int b, int c, int d) {
            Console.WriteLine(a + b + c + d);
        }
        public static int GetSumOfInts(int a, int b) {
            return a + b;
        }
        public static bool StringContainsOtherString(string firstString, string secondString) {
            bool stringContains = firstString.Contains(secondString);
            return stringContains;
        }
        public static string GetJoinedStrings(string a, string b) {
            return a + b;
        }
        public static void PrintJoinedString(string a, string b) {
            Console.WriteLine(a + b);
        }
    }
}
