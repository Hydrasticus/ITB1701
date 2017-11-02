using System;
using System.Collections.Generic;
using System.Linq;

namespace PR09 {
    public class CarRegCodes {
        Random _random = new Random();
        public List<string> _codes = new List<string>();

        public List<string> GenerateFourCodes(string value) {
            while (_codes.Count < 4) {
                string regCode = GenerateCode(value);
                if (!_codes.Contains(regCode)) {
                    _codes.Add(regCode);
                }
            }

            return _codes;
        }
        
        public string GenerateCode(string input) {
            string regCode = "";
            
            if (input.Length == 3) {
                if (input.All(char.IsDigit)) {
                    while (_codes.Count < 4) {
                        regCode = input + GenerateThreeLetters();
                    }
                } else {
                    regCode = GenerateThreeNumbers() + input;
                }
            }
            
            return regCode;
        }

        public string GenerateThreeNumbers() {
            string numbers = "";
            for (int i = 0; i < 3; i++) {
                numbers += _random.Next(1, 11);
            }
            return numbers;
        }

        public string GenerateThreeLetters() {
            string letters = "";
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            for (int i = 0; i < 3; i++) {
                letters += alphabet[_random.Next(alphabet.Length)];
            }
            return letters;
        }
    }
}