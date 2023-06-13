using Interface;
namespace BookModel;

public abstract class Book : IBookBase
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string ISBN { get; set; } = string.Empty;
    public int PublicationYear { get; set; }
    public bool CanBorrow { get; set; }
    public bool CanPrint { get; set; }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nISBN: {ISBN}\nYear of Publication: {PublicationYear}");
    }

    public Book(string title, string author, string isbn, int publicationYear, bool canBorrow, bool canPrint)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationYear = publicationYear;
        CanBorrow = canBorrow;
        CanPrint = canPrint;
    }
}