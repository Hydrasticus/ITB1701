using System;
using System.Collections.Generic;
using System.Linq;

namespace HW10.Ex2 {
    class Library {
        private string _name, _address;
        List<Book> _listOfBooks = new List<Book>();

        public Library(string name) {
            _name = name;
        }

        public void PrintInfo() {
            Console.WriteLine("Library with name '{0}' is located in {1} and has {2} books.",
                _name, _address, GetNumberOfBooksInLibrary());
        }
        
        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        public string Address {
            get { return _address; }
            set { _address = value; }
        }

        public void AddBook(Book bookToAdd) {
            _listOfBooks.Add(bookToAdd);
        }

        public int GetNumberOfBooksInLibrary() {
            return _listOfBooks.Count();
        }

        public Book FindBookByName(string bookName) {
            foreach (Book book in _listOfBooks) {
                if (book.Title.Contains(bookName)) {
                    return book;
                }
            }
            return null;
        }

        public List<Book> FindAllBooksByName(string bookName) {
            List<Book> booksToReturn = new List<Book>();

            foreach (Book book in _listOfBooks) {
                if (book.Title.Contains(bookName)) {
                    booksToReturn.Add(book);
                }
            }
            
            return booksToReturn;
        }

        public List<Book> FindBooksByAuthor(string authorName) {
            List<Book> booksToReturn = new List<Book>();

            foreach (Book book in _listOfBooks) {
                if (book.Author.Contains(authorName)) {
                    booksToReturn.Add(book);
                }
            }

            return booksToReturn;
        }
        
        public List<Book> GetBooksSortedByTitle() {
            return _listOfBooks.OrderBy(book => book.Title).ToList();
        }

        public List<Book> FindAllBooksWithCertainGenre(BookGenre genre) {
            List<Book> booksToReturn = new List<Book>();

            foreach (Book book in _listOfBooks) {
                if (book.Genre == genre) {
                    booksToReturn.Add(book);
                }
            }

            return booksToReturn;
        }

        public void PrintAllBooksWithCertainGenre(BookGenre genre) {
            List<Book> books = FindAllBooksWithCertainGenre(genre);

            Console.WriteLine("\n- All books with genre {0} are:", genre);

            foreach (Book book in books) {
                Console.WriteLine("-- " + book.Title);
            }
        }

        public bool BorrowBook(string bookName) {
            bool wasBorrowingSuccessful = false;
            List<Book> books = FindAllBooksByName(bookName);

            foreach (Book book in books) {
                if (book.GetBorrowedStatus() != true) {
                    book.BorrowBook();
                    wasBorrowingSuccessful = true;
                }
            }
            
            return wasBorrowingSuccessful;
        }

        public bool ReturnBook(string bookName) {
            bool wasReturningSuccessful = false;
            List<Book> books = FindAllBooksByName(bookName);
            
            foreach (Book book in books) {
                if (book.GetBorrowedStatus()) {
                    book.ReturnBook();
                    wasReturningSuccessful = true;
                }
            }
            
            return wasReturningSuccessful;
        }

        public void PrintAllBookTitlesInLibrary() {
            Console.WriteLine("\n- All books are:");
            foreach (Book book in _listOfBooks) {
                Console.Write("-- ");
                book.PrintInfo();
            }
        }

        public void PrintAllBooksByName(string title) {
            List<Book> books = FindAllBooksByName(title);

            Console.WriteLine("\n- All books containing term '{0}' in title are:", title);
            foreach (Book book in books) {
                Console.Write("-- ");
                book.PrintInfo();
            }
        }

        public void PrintAllBooksByAuthor(string author) {
            List<Book> books = FindBooksByAuthor(author);
            
            Console.WriteLine("\n- All books by author '{0}' are:", author);
            foreach (Book book in books) {
                Console.Write("-- ");
                book.PrintInfo();
            }
        }

        public List<Book> GetBooksSinceYear(int year) {
            List<Book> booksSinceYear = new List<Book>();
            
            foreach (Book book in _listOfBooks) {
                if (year > book.ReleaseYear) {
                    booksSinceYear.Add(book);
                }
            }

            return booksSinceYear;
        }
    }
}