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

        public void ShowCost() {
            Console.WriteLine("Date: {0}\nDescription: {1}\nCategory: {2}\nAmount: {3}\n",
                Date, Description, Category, Amount);
        }
    }
    
    public class AccountingSystem {
        private List<Cost> costs;

        public void RunApp() {
            ShowMenu();

            string input = "";
            while (input != "9") {
                input = Console.ReadLine();
                switch (input) {
                    case "1":
                        AddCost();
                        break;
                    case "2":
                        PrintAllCostsByCategoryBetweenDates();
                        break;
                    case "3":
                        PrintAllCostsByText();
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                    case "8":
                        break;
                    default:
                        ShowMenu();
                        break;
                }
            }
        }

        public AccountingSystem() {
            costs = new List<Cost>();
        }

        private void ShowMenu() {
            Console.WriteLine("== Accounting system ==\n1 - Add new entry\n2 - Show all entries of certain category\n" +
                              "3 - Search from entries\n4 - Modify an entry\n5 - Delete an entry\n" +
                              "6 - Sort data descendingly\n7 - Normalize descriptions\n8 - Total expenses/income\n" +
                              "9 - Exit system");
        }
        
        private DateTime ReturnDateByDateString(string dateString) {
            DateTime outputDate;
            
            if (dateString.Length != 8) {
                outputDate = new DateTime();
            } else {
                int date = int.Parse(dateString);
                int day = int.Parse(dateString.Substring(0, 2));
                int month = int.Parse(dateString.Substring(2, 2));
                int year = int.Parse(dateString.Substring(4, 4));
    
                if (day < 1 || day > 31) {
                    outputDate = new DateTime();
                } else if (month < 1 || month > 12) {
                    outputDate = new DateTime();
                } else if (year < 1000 || year > 3000) {
                    outputDate = new DateTime();
                } else if (!int.TryParse(dateString, out date)) {
                    outputDate = new DateTime();
                } else {
                    outputDate = new DateTime(year, month, day);
                }
            }

            return outputDate;
        }

        private void AddCost() {
            Console.Write("Adding new cost\n Date (DDMMYYYY): ");
            string date = Console.ReadLine();
            Console.Write(" Description: ");
            string description = Console.ReadLine();
            Console.Write(" Category: ");
            string category = Console.ReadLine();
            Console.Write(" Amount: ");
            string amount = Console.ReadLine();
            AddCost(date, description, category, amount);
        }
        
        private void AddCost(string date, string description, string category, string amountString) {
            if (costs.Count < 100) {
                DateTime correctDate = ReturnDateByDateString(date);
                int amount = int.Parse(amountString);

                if (correctDate == new DateTime()) {
                    Console.WriteLine("Enter the date in a correct format! DDMMYYYY");
                } else if (string.IsNullOrEmpty(description)) {
                    Console.WriteLine("Enter something as a description!");
                } else if (string.IsNullOrEmpty(category)) {
                    Console.WriteLine("Enter a category!");
                } else if (!int.TryParse(amountString, out amount)) {
                    Console.WriteLine("Incorrect amount!");
                } else {
                    costs.Add(new Cost(correctDate, description, category, amount));
                    Console.WriteLine("New cost added to list! Press any key to continue.");
                }
            } else {
                Console.WriteLine("The system is full! 100 costs reached.");
            }
        }

        private void PrintAllCostsByCategoryBetweenDates() {
            Console.Write("Enter category: ");
            string category = Console.ReadLine();
            Console.Write("Enter start date: ");
            string startDate = Console.ReadLine();
            Console.Write("Enter end date: ");
            string endDate = Console.ReadLine();
            PrintAllCostsByCategoryBetweenDates(category, startDate, endDate);
        }
        
        private void PrintAllCostsByCategoryBetweenDates(string category, string startDate, string endDate) {
            List<Cost> costsByCategory = GetAllCostsByCategoryBetweenDates(category, startDate, endDate);

            if (costsByCategory == null) {
                Console.WriteLine("Operation failed! Try again with different inputs!");
            } else {
                foreach (Cost cost in costsByCategory) {
                    // TODO: Print out all costs by category
                }
            }
        }

        private List<Cost> GetAllCostsByCategoryBetweenDates(string category, string startDate, string endDate) {
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

        private void PrintAllCostsByText() {
            Console.Write("Enter search term: ");
            string text = Console.ReadLine();
            
            if (!string.IsNullOrEmpty(text)) {
                PrintAllCostsByText(text);
            } else {
                Console.WriteLine("Incorrect term!");
            }
        }
        
        private void PrintAllCostsByText(string text) {
            List<Cost> costsByText = GetAllCostsByText(text);

            if (costsByText == null) {
                Console.WriteLine("Operation failed! Try again with some other search term!");
            } else {
                foreach (Cost cost in costsByText) {
                    cost.ShowCost();
                    Console.WriteLine();
                }
            }
        }

        private List<Cost> GetAllCostsByText(string text) {
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

        private void NormalizeDescriptions(int costNr) {
            if (costs[costNr] != null) {
                costs[costNr].Description = costs[costNr].Description.ToLower();
            } else {
                Console.WriteLine("No cost with that number!");
            }
        }
    }
}