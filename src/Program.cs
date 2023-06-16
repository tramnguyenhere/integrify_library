using BookModel;
using LibraryManagement;


// New Comic
var comic1 = new Comic("Love", "Jessi", "abc123", 1986, "Dora");
var comic2 = new Comic("Family", "John", "abc244", 1989, "Dora");

Library library = new Library();

library.BorrowBook(new Customer("Bo"), comic1);
library.PrintListBorrowedBooks();