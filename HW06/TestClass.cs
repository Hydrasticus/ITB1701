using System;

namespace HW06 {
    internal static class TestClass {
        public static void Main(string[] args) {
            RegularIron regIron = new RegularIron();
            LinenIron linIron = new LinenIron();
            PremiumIron premIron = new PremiumIron();

            regIron.DoIroning(89); // Invalid
            regIron.DoIroning(90); // Synthetics
            regIron.TurnOff(); // Turn machine off
            regIron.DoIroning(100); // Turn on first!
            regIron.TurnOn(); // Turn machine on
            regIron.DoIroning(119); // Synthetics
            regIron.DoIroning(120); // Silk
            regIron.Descale(); // Clean
            regIron.DoIroning(120); // Silk
            regIron.DoIroning(149); // Silk
            regIron.DoIroning(150); // Cotton
            regIron.DoIroning(199); // Machine needs cleaning
            regIron.Descale(); // Clean
            regIron.DoIroning(200); // Invalid

            linIron.DoIroning(89); // Invalid
            linIron.DoIroning(90); // Synthetics
            linIron.DoIroning(119); // Synthetics
            linIron.Descale(); // Clean
            linIron.DoIroning(120); // Silk
            linIron.DoIroning(149); // Silk
            linIron.DoIroning(150); // Cotton
            linIron.DoIroning(199); // Machine needs cleaning
            linIron.Descale(); // Clean
            linIron.DoIroning(200); // Linen
            linIron.DoIroning(230); // Linen
            linIron.DoIroning(231); // Invalid
            linIron.TurnOff(); // Turn machine off

            premIron.DoIroning("T-shirt"); // Invalid
            premIron.DoIroning("synthetics"); // Synthetics
            premIron.UseSteam(); // No steam
            premIron.DoIroning("Synthetics"); // Synthetics
            premIron.DoIroning("silk"); // Silk
            premIron.UseSteam(); // Normal steam
            premIron.DoIroning("Silk"); // Silk
            premIron.UseSteam(); // Normal steam
            premIron.DoIroning("cotton"); // Cotton
            premIron.UseSteam(); // Add water
            premIron.DoIroning("Cotton"); // Cotton
            premIron.DoIroning("Linen"); // Self-cleaning
            premIron.DoIroning("Linen"); // Invalid

            Console.ReadLine();
        }
    }
}