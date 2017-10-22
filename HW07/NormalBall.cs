using System;

namespace HW07 {
    public class NormalBall {
        private string _sponsor;
        internal double _diameter, _goalDepth, _weight;
        private int _goalCounter = 0, _missCounter = 0;
        internal int _codeLetters = 4, _codeLength = 9;

        public NormalBall(string sponsor) {
            _sponsor = sponsor;
            _diameter = 0.7;
            _goalDepth = 1.7;
            _weight = 0.45;
        }

        public void GetAverageSpeed(double start, double finish, double time) {
            string output = "The average speed of the ball ";
                        
            if (start < -45 && start > 45) {
                output += "could not be calculated.";
            } else if (finish < -45 && finish > 45) {
                output += "could not be calculated.";
            } else if (time <= 0) {
                output += "could not be calculated.";
            } else
                output += $"is {Math.Abs((finish - start) / time).ToString()} m/s.";
            
            Console.WriteLine(output);
        }

        public void CountGoals(double ballCoordinates, double goalCoordinates) {
            double ballRadius = _diameter / 2;
            if (ballCoordinates - ballRadius >= goalCoordinates - _goalDepth) {
                _goalCounter++;
            } else {
                _missCounter++;
            }
        }

        public void CalculateKineticEnergy(double velocity) {
            if (velocity < 0) {
                Console.WriteLine("Velocity cannot be negative!");
            } else
                Console.WriteLine("The ball's kinetic energy is: {0} J.",
                    (_weight * Math.Pow(velocity, 2)) / 2);
        }

        public void ShowStatistics() {
            Console.WriteLine("== STATISTICS ==\nGoals: {0}\nMissed goals: {1}\n",
                _goalCounter, _missCounter);
        }

        public void PrintUniqueCode() {
            if (_sponsor.Length < _codeLetters) {
                Console.WriteLine("The sponsor name must be at least {0} characters long!", _codeLetters);
            } else {
                Random random = new Random();
                string code = "";

                for (int i = 0; i < _codeLetters; i++) {
                    code += _sponsor[i];
                }

                for (int i = code.Length; i < _codeLength; i++) {
                    code += random.Next(1, 10);
                }

                Console.WriteLine("Ball code: " + code);
            }
        }
    }
}