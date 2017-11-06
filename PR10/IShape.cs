using System;

namespace PR10 {
    public interface IShape {
        void Draw();
    }
    
    public class Circle : IShape {
        public void Draw() {
            Console.WriteLine("I am a circle!");
        }
    }

    public class Square : IShape {
        public void Draw() {
            Console.WriteLine("I am a square!");
        }
    }

    public class Triangle : IShape {
        public void Draw() {
            Console.WriteLine("I am a triangle!");
        }
    }
}