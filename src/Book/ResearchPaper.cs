using Interface;
using BookModel;

public class ResearchPaper : PrintableBook
{
    public ResearchPaper(string title, string author, string isbn, int publicationYear, bool canBorrow, bool canPrint) : base(title, author, isbn, publicationYear, canBorrow, canPrint)
    {
    }
}