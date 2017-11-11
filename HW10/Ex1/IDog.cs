using System;

namespace HW10.Ex1 {
    public interface IDog {
        void Speak();
    }
    
    public class Poodle : IDog {
        public void Speak() {
            Console.WriteLine("The poodle says \"arf\".");
        }
    }

    public class Rottweiler : IDog {
        public void Speak() {
            Console.WriteLine("The rottweiler says (in a very deep voice) \"WOOF!\".");
        }
    }

    public class SiberianHusky : IDog {
        public void Speak() {
            Console.WriteLine("The husky says \"Dude, what's up?\".");
        }
    }
}