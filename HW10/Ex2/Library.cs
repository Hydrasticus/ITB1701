using System;
using System.Collections.Generic;
using System.Linq;

namespace HW10.Ex2 {
    class Library {
        //books in the library are kept in a list with object type of book
        List<Book> _listOfBooks = new List<Book>();

        //method for adding book to the library
        public void AddBook(Book bookToAdd) {
            _listOfBooks.Add(bookToAdd);
        }

        //method for getting the number of all books in the library
        public int GetNumberOfBooksInLibrary() {
            return _listOfBooks.Count();
        }

        //this method returns the FIRST book which contains the name
        public Book FindBookByName(string bookName) {
            foreach (Book a in _listOfBooks) {
                if (a.Title.Contains(bookName)) {
                    return a; //return the FIRST book that contains the name
                }
            }
            return null; //we did not find the book
        }

        //this method returns ALL BOOKS which contains the name
        //the books are returned as a list of books
        public List<Book> FindAllBooksByName(string bookName) {
            //list for returning the results
            List<Book> booksToReturn = new List<Book>();

            //to search for results, we have to iterate through all books
            foreach (Book book in _listOfBooks) {
                if (book.Title.Contains(bookName)) {
                    //if book title contains our search term, we add it to return list
                    booksToReturn.Add(book); //return the book that contains the name
                }
            }
            //returns the list
            //if we found no books, the list is empty
            return booksToReturn;
        }

        //how we could sort list
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
            //just for our own info:

            return booksToReturn;
        }

        public void PrintAllBooksWithCertainGenre(BookGenre genre) {
            //find all books with given genre
            List<Book> books = FindAllBooksWithCertainGenre(genre);

            Console.WriteLine("\n-All books with genre {0}  are :", genre);

            //then we print them
            foreach (Book book in books) {
                Console.WriteLine(book.Title);
            }
        }

        //we return a bool indicating weather a borrowing was successful
        public bool BorrowBook(string bookName) {
            bool wasBorrowingSuccessful = false;

            //we can only borrow if we have this book
            List<Book> books = FindAllBooksByName(bookName);

            //we want to borrow out the first non borrowed book
            foreach (Book book in books) {
                //if the book is not already borrowed out
                if (book.GetBorrowedStatus() != true) {
                    //then we can borrow it
                    book.BorrowBook();
                    //we set the bool to be true to indicate that we can borrow
                    wasBorrowingSuccessful = true;
                }
            }
            return wasBorrowingSuccessful;
        }

        //method for printing out all book titles in the library
        public void PrintAllBookTitlesInLibrary() {
            Console.WriteLine("\n-All books are: ");
            foreach (Book book in _listOfBooks) {
                Console.WriteLine(book.Title);
            }
        }

        public bool ReturnBook(string bookName) {
            //we can only return a book
            //that is in the library and with a status "isBorrowed==true"
            
            return false;
        }

        //lets print all the books that contain certain title
        public void PrintAllBooksByName(string title) {
            //first we find the books
            List<Book> books = FindAllBooksByName(title);

            Console.WriteLine("\n-All books containing term {0} in title are :", title);

            //then we print them
            foreach (Book book in books) {
                Console.WriteLine(book.Title);
            }
        }
    }
}