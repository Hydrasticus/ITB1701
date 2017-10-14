using System;

namespace HW06 {
    internal class Program {
        public static void Main(string[] args) {
            RegularIron regIron = new RegularIron();
            LinenIron linIron = new LinenIron();
            PremiumIron premIron = new PremiumIron();
            
            regIron.TurnOff();
            regIron.TurnOn();
            regIron.DoIroning("Silk");
            regIron.DoIroning("Cotton");
            regIron.UseSteam();
            regIron.DoIroning("synthetics");
            regIron.DoIroning("Linen");
            
            linIron.DoIroning(231);
            linIron.DoIroning(230);
            linIron.DoIroning(200);
            linIron.Descale();
            linIron.DoIroning(199);
            linIron.DoIroning(150);
            linIron.DoIroning(149);
            linIron.Descale();
            linIron.DoIroning(119);
            linIron.DoIroning(90);
            linIron.DoIroning(89);
            linIron.Descale();
            
            premIron.DoIroning(-13);
            premIron.DoIroning(221);
            premIron.DoIroning(199);
            premIron.DoIroning("cotton");
            premIron.DoIroning("Synthetics");
            premIron.DoIroning("underwear");

            Console.ReadLine();
        }
    }
}