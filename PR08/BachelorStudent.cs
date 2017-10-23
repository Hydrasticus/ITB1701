using System;
using System.Collections.Generic;

namespace PR08 {
    public class BachelorStudent : IStudent {
        internal int _credits, _creditsToGraduate = 180;
        internal List<int> _grades = new List<int>();
        internal string _name, _status;

        public BachelorStudent(string name) {
            _status = "active";
            _name = name;
            _credits = 0;
        }
        
        public virtual void AddCredits(int credits) {
            if (IsActive()) {
                _credits += credits;
                if (CanGraduate()){
                    Console.WriteLine("Congratulations, you have {0} credits, you have graduated!",
                        _credits);}
            } else
                Console.WriteLine("The student is inactive, cannot add credits!");
        }

        internal virtual bool IsActive() {
            return _status == "active";
        }
        
        internal virtual bool CanGraduate() {
            return _credits >= _creditsToGraduate;
        }
        
        public virtual void AddGrade(int grade) {
            if (_status == "active") {
                if (grade < 1 || grade > 5) {
                    Console.WriteLine("Cannot add the grade, invalid value!");
                } else {
                    _grades.Add(grade);
                    if (grade == 5) {
                        Console.WriteLine("Good job!");
                    }
                }
            } else
                Console.WriteLine("The student is inactive, cannot add grades!");
        }

        public void ConvertGrade(int percentage) {
            string output = "Converted it to ";

            if (percentage < 0 || percentage > 100) {
                output = "Cannot find grade, invalid value!";
            } else {
                int grade = PercentageToGrades(percentage);
                if (grade != 0) {
                    _grades.Add(grade);
                    output += grade + ", added to student.";
                } else
                    output += grade + ", didn't add to student.";
            }

            Console.WriteLine(output);
        }

        internal virtual int PercentageToGrades(int percentage) {
            if (percentage >= 51 && percentage <= 60) {
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
        
        public void PrintAllGrades() {
            if (_grades.Count != 0) {
                Console.WriteLine("\nStudent's grades:");
                foreach (int grade in _grades) {
                    Console.Write(" " + grade);
                }
                Console.WriteLine();
            } else
                Console.WriteLine("\nThe student doesn't have any grades!");
        }

        public virtual void PrintInfo() {
            Console.WriteLine("\nStudent: {0}\n Credits: {1}", _name, _credits);
        }

        public void PrintLastGrade() {
            if (_grades.Count != 0) {
                Console.WriteLine("\nLast grade given: " + _grades[_grades.Count - 1]);
            } else
                Console.WriteLine("\nThe student doesn't have any grades!");
        }
    }
}