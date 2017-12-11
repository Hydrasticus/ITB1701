using System;
using System.Collections.Generic;

namespace PR15 {
    public class Planet {
        private string _name;
        private int _shipPlatforms;
        private double _weight, _dayInHours, _yearInEarthYears, _yearInSolarDays;
        public List<Spaceship> spaceships;
        private const double EARTH_WEIGHT = 5.97;

        public Planet(string name, double dayInHours, double yearInEarthYears, 
            double yearInSolarDays, double weight, int shipPlatforms) {
            Name = name;
            Weight = weight;
            DayInHours = dayInHours;
            YearInEarthYears = yearInEarthYears;
            YearInSolarDays = yearInSolarDays;
            ShipPlatforms = shipPlatforms;
            spaceships = new List<Spaceship>(ShipPlatforms);
        }
        
        public string Name {
            get => _name;
            set => _name = value;
        }
        
        public double Weight {
            get => _weight;
            set => _weight = value;
        }

        public double DayInHours {
            get => _dayInHours;
            set => _dayInHours = value;
        }

        private double CalculateDayInHours() {
            return Math.Round((YearInEarthYears * 365 * 24) / YearInSolarDays, 2);
        }
        
        public double YearInEarthYears {
            get => _yearInEarthYears;
            set => _yearInEarthYears = value;
        }

        private double CalculateYearInEarthYears() {
            return Math.Round((YearInSolarDays * DayInHours) / (365 * 24), 2);
        }
        
        public double YearInSolarDays {
            get => _yearInSolarDays;
            set => _yearInSolarDays = value;
        }

        private double CalculateYearInSolarDays() {
            return Math.Round((365 * 24 * YearInEarthYears) / DayInHours, 2);
        }
        
        public int ShipPlatforms {
            get => _shipPlatforms;
            set => _shipPlatforms = value;
        }

        public void PrintInfo() {
            double comparison = Math.Round(Weight / EARTH_WEIGHT, 2);
            string comparisonString = comparison > 1 ? "bigger" : "smaller";
            comparison = comparison > 1 ? comparison : 1 - comparison;
            
            if (DayInHours == 0) {
                DayInHours = CalculateDayInHours();
            } else if (YearInEarthYears == 0) {
                YearInEarthYears = CalculateYearInEarthYears();
            } else if (YearInSolarDays == 0) {
                YearInSolarDays = CalculateYearInSolarDays();
            }
            
            Console.WriteLine("\nPlanet: {0}\nIts size is {1} times {2} than Earth. Its day is {3} hours." +
                              " Its year is {4} Earth years and {5} solar days.",
                Name, comparison, comparisonString, DayInHours, YearInEarthYears, YearInSolarDays);
        }

        public void PrintSpaceshipInfo() {
            for (int i = 0; i < spaceships.Count; i++) {
                string shipName = spaceships[i] != null ? spaceships[i].Name : "empty";
                Console.WriteLine("Landing platform {0}: {1}", i + 1, shipName);
            }
        }
    }
}