using System;

namespace PR03 {
    class Person {
        private string _name;
        private int _age;

        public Person() {
            _name = "unknown name";
        }

        public Person(string name) {
            _name = name; //Equal to calling SetName(name)
        }

        public Person(string name, int age) {
            _name = name; //Equal to calling SetName(name)
            _age = age; //Equal to calling SetAge(age)
        }
        
        public void SetName(string name) {
            _name = name;
        }

        public string GetName() {
            return _name;
        }
        
        public void SetAge(int age) {
            _age = age;
        }

        public int GetAge() {
            return _age;
        }

        public void SetAge(DateTime birthYear) {
            _age = DateTime.Today.Year - birthYear.Year;
        }

        public void SetAge(string age) {
            if (age.Length >= 1 && age.Length <= 3) {
                SetAge(int.Parse(age));
            } else if (age.Length == 4) {
                SetAge(new DateTime(int.Parse(age), 1, 1));
            } else {
                Console.WriteLine("Value is not age or birthyear!");
            }
        }
    }
}