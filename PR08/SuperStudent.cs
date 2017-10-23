using System;

namespace PR08 {
    public class SuperStudent : BachelorStudent{
        public SuperStudent(string name) : base(name) {
            _creditsToGraduate = 200;
        }

        public override void AddCredits(int credits) {
            base.AddCredits(credits);
            
            if (base.CanGraduate()) {
                int averageGrade = 0;
                foreach (int grade in _grades) {
                    averageGrade += grade;
                }
                averageGrade = averageGrade / _grades.Count;
                
                Console.WriteLine("Average grade: " + averageGrade);
            }
        }

        internal override bool IsActive() {
            return _status == "active" || _status == "on hold";
        }

        internal override bool CanGraduate() {
            return _grades.Count > 4 && base.CanGraduate();
        }

        public override void AddGrade(int grade) {
            if (_status != "on hold") {
                base.AddGrade(grade);
            } else
                Console.WriteLine("The student is on hold, cannot add grade.");
        }
    }
}