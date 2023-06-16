using Interface;
using BookModel;

public class ResearchPaper : Book
{
    public ResearchPaper(string title, string author, string isbn, int publicationYear) : base(title, author, isbn, publicationYear, false, true)
    {
    }
}