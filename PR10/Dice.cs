using System;

namespace PR10 {
    public class Dice {
        private int _maxSize = 6;
        private int _centerPosition;
        Random _random = new Random();

        public Dice() {
            _centerPosition = _maxSize / 2;
        }

        public void DrawDice() {
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i <= _maxSize; i++) {
                for (int j = 0; j <= _maxSize; j++) {
                    if (i == 0 || i == _maxSize || j == 0 || j == _maxSize) {
                        Console.Write("*");
                    } else {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void RollDice() {
            int value = _random.Next(1, 7);
            ClearDice();
            
            GenerateDots(value);
        }

        private void ClearDice() {
            CenterCursor();

            for (int i = 2; i <= 4; i++) {
                for (int j = 2; j <= 4; j++) {
                    Console.CursorLeft = i;
                    Console.CursorTop = j;
                    
                    Console.Write(" ");
                }
            }
            
            CenterCursor();
        }
        
        private void CenterCursor() {
            Console.CursorLeft = _centerPosition;
            Console.CursorTop = _centerPosition;
        }

        private void GenerateDots(int value) {
            switch (value) {
                    case 1:
                        DiceOne();
                        break;
                    case 2:
                        DiceTwo();
                        break;
                    case 3:
                        DiceThree();
                        break;
                    case 4:
                        DiceFour();
                        break;
                    case 5:
                        DiceFive();
                        break;
                    case 6:
                        DiceSix();
                        break;
            }
        }

        private void DiceOne() {
            Console.Write("*");
        }
        
        private void DiceTwo() {
            for (int i = 2; i <= 4; i++) {
                Console.CursorLeft = i;

                if (i != 3) {
                    Console.Write("*");
                }
            }
        }

        private void DiceThree() {
            for (int i = 2; i <= 4; i++) {
                for (int j = 2; j <= 4; j++) {
                    Console.CursorLeft = i;
                    Console.CursorTop = j;

                    if (i == j) {
                        Console.Write("*");
                    }
                }
            }
        }

        private void DiceFour() {
            for (int i  = 2; i <= 4; i++) {
                for (int j = 2; j <= 4; j++) {
                    Console.CursorLeft = i;
                    Console.CursorTop = j;

                    if (i % 2 == 0 && j % 2 == 0) {
                        Console.WriteLine("*");
                    }
                }
            }
        }

        private void DiceFive() {
            Console.Write("*");
            DiceFour();
        }

        private void DiceSix() {
            for (int i = 2; i <= 4; i++) {
                for (int j = 2; j <= 4; j++) {
                    Console.CursorLeft = i;
                    Console.CursorTop = j;

                    if (j != 3) {
                        Console.Write("*");
                    }
                }
            }
        }
    }
}
