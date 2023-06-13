using Interface;
namespace BookModel;

public class Comic : Book, IBorrowAndReturn
{
    public string Artist { get; set; }
    public Comic(string title, string author, string isbn, int publicationYear, bool canBorrow, bool canPrint, string artist) : base(title, author, isbn, publicationYear, canBorrow, canPrint)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationYear = publicationYear;
        CanBorrow = canBorrow;
        CanPrint = canPrint;
        Artist = artist;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Artist: {Artist}");
    }

    public void Borrow()
    {

    }
    public void Return()
    {

    }
}
