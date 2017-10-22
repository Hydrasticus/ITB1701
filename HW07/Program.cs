using System;
using System.Collections.Generic;

namespace HW07 {
    internal class Program {
        public static void Main(string[] args) {
            NormalBall normalBall = new NormalBall("NORMAL RICH SPONSOR");
            Random random = new Random();

            for (int i = 0; i < 20; i++) {
                normalBall.CountGoals(random.Next(-50, 51), random.Next(-50, 51));
            }

            normalBall.ShowStatistics();
            
            for (int i = 1; i <= 5; i++) {
                normalBall.CalculateKineticEnergy(i);
            }

            for (int i = 0; i <= 10; i++) {
                normalBall.GetAverageSpeed(random.Next(-45, 46), random.Next(-45, 46), random.Next(0, 11));
            }
            
            normalBall.PrintUniqueCode();
            
            YouthBall youthBall = new YouthBall("YOUNG RICH SPONSOR");
            
            for (int i = 0; i < 20; i++) {
                youthBall.CountGoals(random.Next(-50, 51), random.Next(-50, 51));
            }

            youthBall.ShowStatistics();
            
            for (int i = 1; i <= 5; i++) {
                youthBall.CalculateKineticEnergy(i);
            }

            for (int i = 0; i <= 10; i++) {
                youthBall.GetAverageSpeed(random.Next(-45, 46), random.Next(-45, 46), random.Next(0, 11));
            }
            
            youthBall.PrintUniqueCode();
            
            Console.ReadLine();
        }
    }
}