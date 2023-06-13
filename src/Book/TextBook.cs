using Interface;
using BookModel;

public class TextBook : PrintableBook
{
    public TextBook(string title, string author, string isbn, int publicationYear, bool canBorrow, bool canPrint) : base(title, author, isbn, publicationYear, canBorrow, canPrint)
    {
    }
}