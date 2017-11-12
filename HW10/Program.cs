using System;
using System.Collections.Generic;
using HW10.Ex1;
using HW10.Ex2;

namespace HW10 {
    internal class Program {
        static DogFactory dogs = new DogFactory();
        
        public static void Main(string[] args) {
            IDog poodle = dogs.GetDog("small");
            poodle.Speak();
            
            IDog rottweiler = dogs.GetDog("big");
            rottweiler.Speak();
            
            IDog husky = dogs.GetDog("working");
            husky.Speak();
            
            IDog doggo = dogs.GetDog("cute fluffy doggo");
            try {
                doggo.Speak();
            } catch (NullReferenceException) {
                Console.WriteLine("There is no dog there! *BREATHING INTENSIFIES*");
            }
            
            Library library = new Library("Tartu");
            Book potter = new Book("Harry Potter and the Order of the Phoenix");
            Book bullerby = new Book("Bullerby lapsed", "Astrid Lindgren");
            library.AddBook(potter);
            library.AddBook(bullerby);

            library.BorrowBook("Potter");
        }
    }
}