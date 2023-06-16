using PersonModel;
using BookModel;
using Interface;

public class Customer : Person
{
    private List<Book> _borrowedBooks { get; set; }
    public Customer(string name, int id, List<Book> borrowedBooks) : base(name, id)
    {
        Name = name;
        Id = id;
        _borrowedBooks = new List<Book>();
    }

    public void BorrowBook(Book toBeBorrowedbook)
    {
        _borrowedBooks.Add(toBeBorrowedbook);
    }

    public void ReturnBook(Book toBeReturnedBook)
    {
        if (_borrowedBooks.Any(book => book == toBeReturnedBook))
        {
            _borrowedBooks.Remove(toBeReturnedBook);
        }
        else
        {
            throw new Exception("You didn't borrow this book here before!");
        }
    }
}