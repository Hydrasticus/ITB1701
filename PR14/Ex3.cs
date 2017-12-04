using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace PR14 {
    public class Ex3 {
        Random random = new Random();

        public void SomeMeth() {
            int[] randomInts = ReturnRandomInts();
            SortIntsAscend(randomInts);
            Console.WriteLine();
            
            SortIntsDescend(randomInts);
        }
        
        private int[] ReturnRandomInts() {
            int[] randomIntegers = new int[10];
            for (int i = 0; i < randomIntegers.Length; i++) {
                randomIntegers[i] = random.Next(-1000, 1001);
            }

            return randomIntegers;
        }

        private void SortIntsAscend(int[] randomInts) {
            while (!IsInAscendingOrder(randomInts)) {
                for (int i = 0; i < randomInts.Length; i++) {
                    if (!(i + 1 >= randomInts.Length)) {
                        if (randomInts[i] > randomInts[i + 1]) {
                            int placeholder = randomInts[i];
                            randomInts[i] = randomInts[i + 1];
                            randomInts[i + 1] = placeholder;
                        }
                    }
                }
            }

            foreach (int i in randomInts) {
                Console.WriteLine(i);
            }
        }

        private void SortIntsDescend(int[] randomInts) {
            while (!IsInDescendingOrder(randomInts)) {
                for (int i = 0; i < randomInts.Length; i++) {
                    if (!(i + 1 >= randomInts.Length)) {
                        if (randomInts[i] < randomInts[i + 1]) {
                            int placeholder = randomInts[i];
                            randomInts[i] = randomInts[i + 1];
                            randomInts[i + 1] = placeholder;
                        }
                    }
                }
            }
            
            foreach (int i in randomInts) {
                Console.WriteLine(i);
            }
        }
        
        private bool IsInAscendingOrder(int[] randomInts) {
            int counter = 0;
            for (int i = 0; i < randomInts.Length; i++) {
                if (!(i + 1 >= randomInts.Length)) {
                    if (randomInts[i] > randomInts[i + 1]) {
                        counter++;
                    }
                }
            }

            return counter <= 0;
        }

        private bool IsInDescendingOrder(int[] randomInts) {
            int counter = 0;
            for (int i = 0; i < randomInts.Length; i++) {
                if (!(i + 1 >= randomInts.Length)) {
                    if (randomInts[i] < randomInts[i + 1]) {
                        counter++;
                    }
                }
            }

            return counter <= 0;
        }
    }
}