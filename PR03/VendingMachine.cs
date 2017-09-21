using System;

namespace PR03 {
    public class VendingMachine {
        private int depositedAmount;
        const int COST_OF_DRINK = 75;

        public VendingMachine() {
            depositedAmount = 0;
        }
        
        //We add money to the machine.
        public void DepositCoin(int coinAmount) {
            depositedAmount += coinAmount;
            Console.WriteLine("You have inserted {0} coins.", depositedAmount);
        }

        public void GetDrink() {
            if (depositedAmount >= 75) {
                Console.WriteLine("You bought a drink.");
                
                depositedAmount -= COST_OF_DRINK;
                Console.WriteLine("Your change is {0} cents.", depositedAmount);
                
                depositedAmount = 0;
            } else if (depositedAmount >=0 && depositedAmount < 75) {
                Console.WriteLine("Insert more coins!");
            } else {
                Console.WriteLine("Holy shit, my dude. What are you doing?");
            }
        }

        public void GetRefund() {
            if (depositedAmount >= 0) {
                Console.WriteLine("You were refunded {0} cents.", depositedAmount);
            } else {
                Console.WriteLine("Can't even deal with your bullshit right now.");
            }
            
            depositedAmount = 0;
        }
    }
}