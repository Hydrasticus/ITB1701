using System;
using System.Collections.Generic;

namespace HW14 {
    public class Cost {
        private DateTime _date;
        private string _description, _category;
        private int _amount;

        public Cost(DateTime date, string description, string category, int amount) {
            Date = date;
            Description = description;
            Category = category;
            Amount = amount;
        }

        public DateTime Date {
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

        public void ShowDate() {
            Console.WriteLine("Date: {0}\nDescription: {1}\nCategory: {2}\nAmount: {3}\n",
                Date, Description, Category, Amount);
        }
    }
    
    public class AccountingSystem {
        private List<Cost> costs;

        public AccountingSystem() {
            costs = new List<Cost>();
        }

        private DateTime ReturnDateByDateString(string date) {
            DateTime outputDate;
            
            int day = int.Parse(date.Substring(0, 2));
            int month = int.Parse(date.Substring(2, 2));
            int year = int.Parse(date.Substring(4, 4));
            
            if (date.Length != 8) {
                outputDate = new DateTime();
            } else if (day < 1 || day > 31) {
                outputDate = new DateTime();
            } else if (month < 1 || month > 12) {
                outputDate = new DateTime();
            } else if (year < 1000 || year > 3000) {
                outputDate = new DateTime();
            } else {
                outputDate = new DateTime(year, month, day);
            }

            return outputDate;
        }
        
        public void AddCost(string date, string description, string category, int amount) {
            if (costs.Count < 100) {
                DateTime correctDate = ReturnDateByDateString(date);
                
                if (correctDate == new DateTime()) {
                    Console.WriteLine("Enter the date in a correct format! DDMMYYYY");
                } else if (string.IsNullOrEmpty(description)) {
                    Console.WriteLine("Enter something as a description!");
                } else if (string.IsNullOrEmpty(category)) {
                    Console.WriteLine("Enter a category!");
                } else {
                    costs.Add(new Cost(correctDate, description, category, amount));
                }
            } else {
                Console.WriteLine("The system is full! 100 costs reached.");
            }
        }

        public void NormalizeDescriptions(int costNr) {
            costs[costNr].Description = costs[costNr].Description.ToLower();
        }

        private List<Cost> ShowAllCostsByCategoryBetweenDates(string category, string startDate, string endDate) {
            List<Cost> costsByCategory = new List<Cost>();
            category = category.ToLower();
            DateTime start = ReturnDateByDateString(startDate);
            DateTime end = ReturnDateByDateString(endDate);

            if (start == new DateTime() || end == new DateTime()) {
                return null;
            }
            
            foreach (Cost cost in costs) {
                string rawCategory = cost.Category.ToLower();
                
                if (rawCategory == category.ToLower() && cost.Date >= start && cost.Date <= end) {
                    costsByCategory.Add(cost);
                }
            }

            return costsByCategory;
        }

        public void PrintAllCostsByCategoryBetweenDates(string category, string startDate, string endDate) {
            List<Cost> costsByCategory = ShowAllCostsByCategoryBetweenDates(category, startDate, endDate);

            if (costsByCategory == null) {
                Console.WriteLine("Operation failed! Try again with different inputs!");
            } else {
                foreach (Cost cost in costsByCategory) {
                    // TODO: Print out all costs by category
                }
            }
        }
        
        private List<Cost> ShowAllCostsByText(string text) {
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

        public void PrintAllCostsByText(string text) {
            List<Cost> costsByText = ShowAllCostsByText(text);

            if (costsByText == null) {
                Console.WriteLine("Operation failed! Try again with some other search term!");
            } else {
                foreach (Cost cost in costsByText) {
                    // TODO: Print out all costs by text
                }
            }
        }
    }
}