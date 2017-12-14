using System;
using System.Collections.Generic;

namespace HW14 {
    public class Cost {
        private int _amount;
        private string _date, _description, _category;

        public Cost(string date, string description, string category, int amount) {
            Date = date;
            Description = description;
            Category = category;
            Amount = amount;
        }

        public string Date {
            get => _date;
            set => _date = value;
        }

        public string Description {
            get => _description;
            set => _description = value;
        }

        public string Category {
            get => _category;
            set => _category = value;
        }

        public int Amount {
            get => _amount;
            set => _amount = value;
        }
    }
    
    public class AccountingSystem {
        private List<Cost> costs;

        public AccountingSystem() {
            costs = new List<Cost>();
        }
        
        public void AddCost(string date, string description, string category, int amount) {
            if (costs.Count < 100) {
                if (date.Length != 8) {
                    Console.WriteLine("Enter the date in a correct format! DDMMYYYY");
                } else {
                    string day = date.Substring(0, 2);
                    string month = date.Substring(2, 2);
                    string year = date.Substring(4, 4);
                }
            } else {
                Console.WriteLine("The system is full! 100 costs reached.");
            }
        }
    }
}