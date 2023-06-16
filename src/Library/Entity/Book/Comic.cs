using Interface;
using LibraryManagement;

namespace BookModel;

public class Comic : Book, IBorrowAndReturn
{
    private string? _artist;

    public string Artist { get; set; } = string.Empty;
    public Comic(string title, string author, string isbn, int publicationYear, string artist) : base(title, author, isbn, publicationYear, true, false)
    {
        _artist = artist;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Artist: {_artist}");
    }
}
