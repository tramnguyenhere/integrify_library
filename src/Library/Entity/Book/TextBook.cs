using Interface;
using BookModel;

public class TextBook : Book
{
    public TextBook(string title, string author, string isbn, int publicationYear) : base(title, author, isbn, publicationYear, true, true)
    {
    }

    public void PrintPages(int startPage, int endPage)
    {
        Console.WriteLine($"Book print from {startPage} to {endPage}");
    }
}