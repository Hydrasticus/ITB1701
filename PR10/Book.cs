using System;

namespace PR10 {
    public enum BookGenre {
        Horror,
        SciFi,
        Romance,
        Drama
    }

    public class Book {
        private string _title;
        private BookGenre _genre;
        private bool _isAvailable;

        public Book() {
            _isAvailable = true;
        }

        public Book(string title) {
            _isAvailable = true;
            _title = title;
        }

        public BookGenre Genre {
            get { return _genre; }
            set { _genre = value; }
        }

        public bool GetAvailability() {
            return _isAvailable;
        }
        
        public void BorrowBook() {
            _isAvailable = false;
        }
        
        public void ReturnBook() {
            _isAvailable = true;
        }
        
        public string Title {
            get { return "Title: " + _title; }
            set {
                if (value != "") {
                    _title = value;
                } else {
                    Console.WriteLine("Invalid value!");
                }
            }
        }
    }
}