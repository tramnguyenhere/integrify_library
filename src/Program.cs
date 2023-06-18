using BookModel;
using PersonModel;
using LibraryManagement;


// New Book
var comic1 = new Comic("Love", "Jessi", "abc123", 1986, "Dora");
var comic2 = new Comic("Family", "John", "abc244", 1989, "Dora");

// New Users
var customer1 = new Customer("Jessica");
var librarian1 = new Librarian("John");

// New Library
Library library = new Library();

//Librarian actions
library.AddBook(librarian1, comic1);

//Perform check book collection
library.PrintListBooks();

//Customer actions
library.BorrowBook(customer1, comic1);

//Perform check borrowed book collection
library.PrintListBorrowedBooks();
