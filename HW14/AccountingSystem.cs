using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace HW14 {
    public class Cost {
        private string _date, _description, _category;
        private int _amount;

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
                    costs.Add(new Cost(date, description, category, amount));
                }
            } else {
                Console.WriteLine("The system is full! 100 costs reached.");
            }
        }

        public void NormalizeDescriptions(int costNr) {
            costs[costNr].Description = costs[costNr].Description.ToLower();
        }

        public List<Cost> ShowAllCostsByCategory(string category) {
            List<Cost> costsByCategory = new List<Cost>();
            
            foreach (Cost cost in costs) {
                string rawCategory = cost.Category.ToLower();
                category = category.ToLower();
                
                if (rawCategory == category.ToLower()) {
                    costsByCategory.Add(cost);
                }
            }

            return costsByCategory;
        }

        public List<Cost> ShowAllCostsByText(string text) {
            List<Cost> costsByText = new List<Cost>();
            
            foreach (Cost cost in costs) {
                string rawCategory = cost.Category.ToLower();
                string rawDescription = cost.Description.ToLower();
                
                if (rawCategory.Contains(text.ToLower()) || rawDescription.Contains(text.ToLower())) {
                    costsByText.Add(cost);
                }
            }

            return costsByText;
        }
    }
}