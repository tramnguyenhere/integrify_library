using Interface;
namespace BookModel;

public class Novel : Book, IBorrowAndReturn
{
    private string? _genre;

    public string Genre { get; set; } = string.Empty;

    public Novel(string title, string author, string isbn, int publicationYear, string genre) : base(title, author, isbn, publicationYear, true, false)
    {
        _genre = genre;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Genre: {_genre}");
    }
}