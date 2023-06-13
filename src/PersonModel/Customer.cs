using PersonModel;
using Interface;

public class Customer : Person
{
    private List<IBookBase> _borrowedBooks { get; set; }
    public Customer(string name, int id, List<IBookBase> borrowedBooks) : base(name, id)
    {
        Name = name;
        Id = id;
        _borrowedBooks = new List<IBookBase>();
    }

    public void BorrowBook(IBookBase toBeBorrowedbook)
    {
        _borrowedBooks.Add(toBeBorrowedbook);
    }

    public void ReturnBook(IBookBase toBeReturnedBook)
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