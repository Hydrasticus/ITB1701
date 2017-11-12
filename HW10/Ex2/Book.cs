using System;

namespace HW10.Ex2 {
    public enum BookGenre {
        Horror,
        ScienceFiction,
        Romance,
        Drama
    }

    public class Book {
        private string _title, _author;
        private int _releaseYear;
        private BookGenre _genre;
        private bool _isBorrowed;

        public Book() {
            _isBorrowed = false;
        }

        public Book(string title) {
            _isBorrowed = false;
            _title = title;
        }

        public Book(string title, string author) {
            _isBorrowed = false;
            _title = title;
            _author = author;
        }

        public string Title {
            get { return _title; }
            set {
                if (value != "") {
                    _title = value;
                } else {
                    Console.WriteLine("Invalid value!");
                }
            }
        }

        public string Author {
            get { return _author; }
            set {
                if (value != "") {
                    _author = value;
                } else {
                    Console.WriteLine("Invalid value!");
                }
            }
        }

        public int ReleaseYear {
            get { return _releaseYear; }
            set { _releaseYear = value; }
        }

        public BookGenre Genre { 
            get { return _genre; }
            set { _genre = value; }
        }

        public bool GetBorrowedStatus() {
            return _isBorrowed;
        }

        public void BorrowBook() {
            _isBorrowed = true;
        }

        public void ReturnBook() {
            _isBorrowed = false;
        }

        public bool CompareBook(Book book) {
            return book.Title == _title && book.Author == _author;
        }

        public void PrintInfo() {
            Console.WriteLine("'{0}' by {1}, {2}", _title, _author, _releaseYear);
        }
    }
}