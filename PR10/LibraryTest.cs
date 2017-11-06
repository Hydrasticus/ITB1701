using NUnit.Framework;

namespace PR10 {
    [TestFixture]
    public class LibraryTest {
        private Library myLibrary;
        private Book book1, book2, book3;
        
        [SetUp]
        public void CreateObjects() {
            book1 = new Book("How To Build A Hydrogen Bomb?");
            book1.Genre = BookGenre.SciFi;
            
            book2 = new Book("Eat Shit And Die");
            book2.Genre = BookGenre.SciFi;
            
            book3 = new Book("Love Food");
            book3.Genre = BookGenre.Romance;
            
            myLibrary = new Library();
        }

        [Test]
        public void TestAdding1BookToLibrary() {
            myLibrary.AddBook(book1);
            Assert.AreEqual(myLibrary.GetNumberOfBooksInLibrary(), 1);
        }

        [Test]
        public void TestFinding1Book() {
            myLibrary.AddBook(book1);
            Assert.AreEqual(book1.Title, myLibrary.FindBookByName("Bomb").Title);
        }

        [Test]
        public void TestFindingBooksByGenreSciFi() {
            myLibrary.AddBook(book1);
            myLibrary.AddBook(book2);
            myLibrary.AddBook(book3);
            
            Assert.AreEqual(myLibrary.FindBooksByGenre(BookGenre.SciFi).Count, 2);
        }

        [Test]
        public void TestBorrowBook() {
            myLibrary.AddBook(book1);
            myLibrary.BorrowBook("Bomb");
            
            Assert.IsTrue(book1.GetAvailability() == false);
        }
    }
}