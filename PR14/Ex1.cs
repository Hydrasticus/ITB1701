using System;

namespace PR14 {
    public class Ex1 {
        public double GetSumOfGrains(int squares) {
            double grains = 0;
            for (int i = 0; i < squares; i++) {
                grains += ReturnGrainsOnSquare(i);
            }

            return grains;
        }

        private double ReturnGrainsOnSquare(int square) {
            return Math.Pow(2, square);
        }
    }
}