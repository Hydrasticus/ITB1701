using HW10.Ex2;
using NUnit.Framework;

namespace HW10.Tests {
    [TestFixture]
    public class LibraryTests {
        private Library library1;
        private Library library2;
        private Book book1;
        private Book book2;
        private Book book3;
        private Book book4;
        private Book book5;
        private Book book6;
        private Book book7;
        private Book book8;
        private Book book9;
        private Book book10;
        
        [SetUp]
        public void TestSetup() {
            library1 = new Library("Random Library");
            library1.Address = "4/20 Random St.";
            library1.AddBook(book1);
            library1.AddBook(book2);
            library1.AddBook(book3);
            library1.AddBook(book4);

            library2 = new Library("Casual Library");
            library2.Name = "Special Library";
            library2.AddBook(book5);
            library2.AddBook(book6);
            library2.AddBook(book7);
            library2.AddBook(book8);
            library2.AddBook(book9);
            library2.AddBook(book10);
            
            book1 = new Book("Harry Potter and the Order of the Phoenix", "J. K. Rowling");
            book1.ReleaseYear = 2003;
            book1.Genre = BookGenre.Fantasy;
            
            book2 = new Book("The Sorceress", "Michael Scott");
            book2.ReleaseYear = 2009;
            
            book3 = new Book("The Six Bullerby Children");
            book3.ReleaseYear = 1947;
            
            book4 = new Book();
            book4.Title = "The Shattering";
            book4.Author = "Christie Golden";

            book5 = new Book();
            book5.Genre = BookGenre.Horror;
            
            book6 = new Book();
            book6.Title = "Beyond the Dark Portal";
            
            book7 = new Book("Lohe hambad");
            book7.Author = "Karl Ristikivi";
            book7.BorrowBook();
            
            book8 = new Book();
            book8.ReleaseYear = 1984;
            
            book9 = new Book();
            book9.Author = "Stephen King";
            book9.Genre = BookGenre.Horror;
            
            book10 = new Book();
        }

        [Test]
        public void TestLibrary1BookCount() {
            int count = 4;
            
            Assert.AreEqual(count, library1.GetNumberOfBooksInLibrary());
        }

        [Test]
        public void TestBook1Title() {
            string title = "Harry Potter and the Order of the Phoenix";
            
            Assert.AreEqual(title, book1.Title);
        }

        [Test]
        public void TestBook1Author() {
            string author = "J. K. Rowling";
            
            Assert.AreEqual(author, book1.Author);
        }

        [Test]
        public void TestBook4Title() {
            string title = "The Shattering";
            
            Assert.AreEqual(title, book4.Title);
        }

        [Test]
        public void TestSetBook4Author() {
            string author = "Christie Golden";
            
            Assert.AreEqual(author, book4.Author);
        }

        [Test]
        public void TestBook5TitleNull() {
            Assert.IsNull(book5.Title);
        }

        [Test]
        public void TestBook5AuthorNull() {
            Assert.IsNull(book5.Author);
        }

        [Test]
        public void TestGetBook1Genre() {
            BookGenre genre = BookGenre.Fantasy;
            
            Assert.AreEqual(genre, book1.Genre);
        }
    }
}