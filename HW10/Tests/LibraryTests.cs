using HW10.Ex2;
using NUnit.Framework;

namespace HW10.Tests {
    [TestFixture]
    public class LibraryTests {
        private Library library;
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
            library = new Library("Suvaline raamatukogu");
            book1 = new Book("Harry Potter and the Order of the Phoenix", "J. K. Rowling");
            book2 = new Book("The Sorceress", "Michael Scott");
            book3 = new Book("The Six Bullerby Children");
            book4 = new Book();
            book5 = new Book();
            book6 = new Book();
            book7 = new Book();
            book8 = new Book();
            book9 = new Book();
            book10 = new Book();
        }

        [Test]
        public void TestBook1Title() {
            string title = "Harry Potter and the Order of the Phoenix";
            
            Assert.AreEqual(title, book1.Title);
        }

        [Test]
        public void TestBook4TitleNull() {
            Assert.IsNull(book4.Title);
        }

        [Test]
        public void TestSetBook4Title() {
            string title = "The Shattering";
            book4.Title = title;
            
            Assert.AreEqual(title, book4.Title);
        }
    }
}