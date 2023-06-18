using BookModel;
using PersonModel;
using LibraryManagement;


// New Book
var comic1 = new Comic("Love", "Jessi", "abc123", 1986, "Dora");
var textBook1 = new TextBook("Math", "Tram", "abc244", 2023);

// New Users
var customer1 = new Customer("Jessica");
var librarian1 = new Librarian("John");

// New Library
Library library = new Library();

//Librarian actions
library.AddBook(librarian1, comic1);
library.AddBook(librarian1, textBook1);

//Customer actions
library.BorrowBook(customer1, comic1);

//Perform check borrowed book collection
library.PrintListBorrowedBooks();

//Perform check book collection
library.PrintListBooks();

//Check print book
comic1.PrintPages(4,7);
textBook1.PrintPages(4,7);