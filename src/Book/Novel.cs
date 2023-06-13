using Interface;
namespace BookModel;

public class Novel : Book, IBorrowAndReturn
{
    public string Genre { get; set; }
    public Novel(string title, string author, string isbn, int publicationYear, bool canBorrow, bool canPrint, string genre) : base(title, author, isbn, publicationYear, canBorrow, canPrint)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationYear = publicationYear;
        CanBorrow = true;
        CanPrint = canPrint;
        Genre = genre;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Genre: {Genre}");
    }
}