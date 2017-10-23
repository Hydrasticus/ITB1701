using System;
using System.Collections.Generic;

namespace PR08 {
    internal class Program {
        public static void Main(string[] args) {
            Random random = new Random();
            BachelorStudent bachelor = new BachelorStudent("Anti Vastatatti");

            for (int i = 0; i < 20; i++) {
                bachelor.AddCredits(random.Next(1, 20));
                bachelor.AddGrade(random.Next(-1, 7));
                bachelor.ConvertGrade(random.Next(-10, 111));
            }

            bachelor.PrintLastGrade();
            bachelor.PrintAllGrades();
            bachelor.PrintInfo();

            BachelorStudent alo = new BachelorStudent("Alo Pullmann");

            for (int i = 0; i < 20; i++) {
                alo.AddCredits(random.Next(1, 20));
                alo.AddGrade(random.Next(-1, 7));
                alo.ConvertGrade(random.Next(-10, 111));
            }
            
            alo.PrintLastGrade();
            alo.PrintAllGrades();
            alo.PrintInfo();

            MasterStudent master = new MasterStudent("Tom Kruiis", 123456);
            
            for (int i = 0; i < 20; i++) {
                master.AddCredits(random.Next(1, 20));
                master.AddGrade(random.Next(0, 7));
                master.ConvertGrade(random.Next(-10, 111));
            }
            
            master.PrintLastGrade();
            master.PrintAllGrades();
            master.PrintInfo();

            SuperStudent super = new SuperStudent("Ülle Hüppa-Mulle-Sülle");
            
            for (int i = 0; i < 20; i++) {
                super.AddCredits(random.Next(1, 20));
                super.AddGrade(random.Next(0, 7));
                super.ConvertGrade(random.Next(-10, 111));
            }
            
            super.PrintLastGrade();
            super.PrintAllGrades();
            super.PrintInfo();

            Console.ReadLine();
        }
    }
}