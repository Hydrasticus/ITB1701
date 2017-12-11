using System;
using System.Collections.Generic;

namespace PR15 {
    internal class Program {
        public static PlanetarySystem solarSystem;
        
        public static void Main(string[] args) {
            solarSystem = new PlanetarySystem();
            solarSystem.planets[2].PrintInfo();
            solarSystem.planets[0].PrintInfo();
            solarSystem.planets[1].PrintInfo();
            
            Spaceship tyrnyhvel = new Spaceship("Türnühvel", false);
            Spaceship sitavikat = new Spaceship("Sitavikat", true);
            Spaceship kosmoselaev = new Spaceship("Kosmoselaev", true);
            Spaceship keks = new Spaceship("Keks", false);
            Spaceship pepe = new Spaceship("Pepe", false);
            Spaceship normie = new Spaceship("Normie", false);
            
            Spaceship dingo = new Spaceship("Dingo", false);
            Spaceship motherRussia = new Spaceship("Mother Russia", false);
            solarSystem.planets[2].PrintSpaceshipInfo();
            
            pepe.Travel(4); //fail
            pepe.Travel(-1); //success
            pepe.Travel(2); //success
            
            sitavikat.Travel(5); //fail
            sitavikat.Travel(4); //success
            sitavikat.Travel(6); //fail
            sitavikat.Travel(8); //fail
            
            solarSystem.PrintInfo();
        }
    }
}