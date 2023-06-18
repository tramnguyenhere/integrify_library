using Interface;
using Entity;
using LibraryManagement;

namespace BookModel;

public abstract class Book : BaseEntity
{
    private string _title;
    private string _author;
    private string _isbn;
    private int _publicationYear;
    private bool _canBorrow;
    private bool _canPrint;

    public string Title
    {
        get
        {
            return _title;
        }
        set
        {
            if (value == null || value == "")
            {
                throw new Exception("Title cannot be empty");
            }
            else
            {
                _title = value;
            }
        }
    }
    public string Author
    {
        get
        {
            return _author;
        }
        set
        {
            if (value == null || value == "")
            {
                throw new Exception("Author cannot be empty");
            }
            else
            {
                _author = value;
            }
        }
    }
    public string ISBN
    {
        get
        {
            return _isbn;
        }
        set
        {
            if (value == null || value == "")
            {
                throw new Exception("ISBN cannot be empty");
            }
            else
            {
                _isbn = value;
            }
        }
    }

    public int PublicationYear
    {
        get
        {
            return _publicationYear;
        }
        set
        {
            _publicationYear = value;

        }
    }

    public bool CanBorrow
    {
        get
        {
            return _canBorrow;
        }
    }

    public bool CanPrint
    {
        get
        {
            return _canPrint;
        }
    }

    public Book(string title, string author, string isbn, int publicationYear, bool canBorrow, bool canPrint) : base()
    {
        _title = title;
        _author = author;
        _isbn = isbn;
        _publicationYear = publicationYear;
        _canBorrow = canBorrow;
        _canPrint = canPrint;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Id: {Id}\nTitle: {Title}\nAuthor: {Author}\nISBN: {ISBN}\nYear of Publication: {PublicationYear}");
    }

    public virtual void PrintPages(int startPage, int endPage)
    {
        if (_canPrint)
        {
            Console.WriteLine($"Book print from page {startPage} to page {endPage}");
        }
        else
        {
            Console.WriteLine("Printing is not available for this book.");
        }
    }
}