using System;

namespace PR08 {
    public class MasterStudent : BachelorStudent {
        private int _masterStudentNumber;
        
        public MasterStudent(string name, int masterStudentNumber) : base(name) {
            _masterStudentNumber = masterStudentNumber;
            _creditsToGraduate = 120;
        }

        internal override int PercentageToGrades(int percentage) {
            if (percentage >= 40 && percentage <= 60) {
                return 1;
            } else if (percentage >= 61 && percentage <= 70) {
                return 2;
            } else if (percentage >= 71 && percentage <= 80) {
                return 3;
            } else if (percentage >= 81 && percentage <= 90) {
                return 4;
            } else if (percentage >= 91 && percentage <= 100) {
                return 5;
            } else
                return 0;
        }

        public override void PrintInfo() {
            base.PrintInfo();
            Console.WriteLine(" Student number: " + _masterStudentNumber);
        }
    }
}