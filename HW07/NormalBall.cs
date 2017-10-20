using System;

namespace HW07 {
    public class NormalBall {
        internal int _diameter;
        internal double _goalDepth;
        internal double _weight;
        internal string _sponsor;
        internal int _goals = 0;
        internal int _missed = 0;

        public NormalBall() {}

        public NormalBall(string sponsor) {
            _sponsor = sponsor;
            _diameter = 70;
            _goalDepth = 1.7;
            _weight = 0.45;
        }

        double ReturnAverageSpeed(double start, double finish, double time) {
            return (finish - start) / time;
        }

        void CountGoals(double ballCoordinates, double goalCoordinates) {
            int ballRadius = _diameter / 2;
            if (ballCoordinates - ballRadius >= goalCoordinates - _goalDepth) {
                _goals++;
            } else {
                _missed++;
            }
        }

        double ReturnKineticEnergy(double velocity) {
            return _weight * Math.Pow(velocity, 2);
        }

        void ReturnGoals() {
            Console.WriteLine("==STATISTICS==\nCounted goals: {0}\nMissed goals: {1}\n",
                _goals, _missed);
        }

        internal virtual void PrintUniqueCode() {
            Random random = new Random();

            string code = "";

            for (int i = 0; i < 3; i++) {
                code += _sponsor[i];
            }

            for (int i = code.Length; i <= 9; i++) {
                code += random.Next(1, 10);
            }
            
            Console.WriteLine("Ball code: " + code);
        }
    }
}