using System;

namespace PR15 {
    public class PlanetarySystem {
        Planet mercury = new Planet("Mercury", 4222.6, 0, 0.498, 0.33, 1);
        Planet venus = new Planet("Venus", 0, 0.62, 1.93, 4.87, 2);
        Planet earth = new Planet("Earth", 24, 1, 365, 5.97, 6);
        Planet mars = new Planet("Mars", 24.7, 1.88, 0, 0.642, 2);
        Planet jupiter = new Planet("Jupiter", 9.9, 11.86, 0, 1898, 2);
        Planet saturn = new Planet("Saturn", 0, 29.46, 24491, 586, 1);
        Planet uranus = new Planet("Uranus", 17.2, 0, 42786, 86.8, 0);
        Planet neptune = new Planet("Neptune", 16.1, 164.8, 0, 102, 1);
        
        public Planet[] planets;
        private Planet[] solarSystem;
        
        public PlanetarySystem() {
            planets = new[] { mercury, venus, earth, mars, jupiter, saturn, uranus, neptune };
        }

        public PlanetarySystem(int nrOfPlanets) {
            if (nrOfPlanets < 3) {
                Console.WriteLine("The minimum amount of planets is 3.");
            } else if (nrOfPlanets > 8) {
                Console.WriteLine("The maximum amount of planets is 8.");
            } else {
                solarSystem = new[] { mercury, venus, earth, mars, jupiter, saturn, uranus, neptune };
                planets = new Planet[nrOfPlanets];
                for (int i = 0; i < nrOfPlanets; i++) {
                    planets[i] = solarSystem[i];
                }
            }
        }

        public void PrintInfo() {
            Console.WriteLine("\nPlanetary system info:");
            foreach (Planet planet in planets) {
                planet.PrintInfo();
                planet.PrintSpaceshipInfo();
            }
        }
    }
}