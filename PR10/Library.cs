using System;
using System.Collections.Generic;

namespace PR10 {
    public class Library {
        List<Book> _books = new List<Book>();

        public void AddBook(Book bookToAddBook) {
            _books.Add(bookToAddBook);
        }

        public int GetNumberOfBooksInLibrary() {
            return _books.Count;
        }
        
        public Book FindBookByName(string bookName) {
            foreach (Book book in _books) {
                if (book.Title.Contains(bookName)) {
                    return book;
                }
            }
            return null;
        }
        
        public List<Book> FindBooksByGenre(BookGenre genre) {
            List<Book> booksByGenre = new List<Book>();

            foreach (Book book in _books) {
                if (book.Genre == genre) {
                    booksByGenre.Add(book);
                }
            }
            
            Console.WriteLine("All books with genre {0} are: ", genre);
            foreach (Book book in booksByGenre) {
                Console.WriteLine(book.Title);
            }
            
            return booksByGenre;
        }

        public void BorrowBook(string bookName) {
            Book book = FindBookByName(bookName);
            
            if (book != null) {
                foreach (Book foundBook in _books) {
                    if (foundBook.GetAvailability()) {
                        foundBook.BorrowBook();
                    }
                }
            }
        }

        public void ReturnBook(string bookName) {
            Book book = FindBookByName(bookName);

            if (book != null) {
                foreach (Book foundBook in _books) {
                    if (!foundBook.GetAvailability()) {
                        foundBook.ReturnBook();
                    }
                }
            }
        }
    }
}