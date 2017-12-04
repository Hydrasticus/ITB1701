using System;
using System.IO;

namespace PR14 {
    public class Ex2 {
        public void RandomMeth() {
            string deathPath = "D:\\Desktop\\EX14\\surmad_1.txt";
            string birthPath = "D:\\Desktop\\EX14\\synnid_1.txt";

            int[] births = new int[12];
            int[] deaths = new int[12];

            using (StreamReader reader = new StreamReader(birthPath)) {
                string line;
                int index = 0;
                while ((line = reader.ReadLine()) != null) {
                    births[index] = (int.Parse(line));
                    index++;
                }
            }

            using (StreamReader reader = new StreamReader(deathPath)) {
                string line;
                int index = 0;
                while ((line = reader.ReadLine()) != null) {
                    deaths[index] = (int.Parse(line));
                    index++;
                }
            }
            
            int[] growthRates = GetGrowthRate(births, deaths);

            GetAllGrowthRates(growthRates);
            GetNumberOfPositiveMonths(growthRates);
        }

        private int[] GetGrowthRate(int[] births, int[] deaths) {
            int[] growthRate = new int[12];
            
            for (int i = 0; i < births.Length; i++) {
                growthRate[i] = (births[i] - deaths[i]);
            }

            return growthRate;
        }

        private void GetAllGrowthRates(int[] growthRates) {
            string[] months = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", 
                "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};
            
            for (int i = 0; i < growthRates.Length; i++) {
                Console.WriteLine("{1}: {0}", growthRates[i], months[i]);
            }
        }

        private void GetNumberOfPositiveMonths(int[] growthRates) {
            int positiveMonths = 0;
            
            foreach (var growthRate in growthRates) {
                if (growthRate > 0) {
                    positiveMonths++;
                }
            }

            Console.WriteLine("Population growth was positive in {0} months.", positiveMonths);
        }
    }
}