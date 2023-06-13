using Interface;

namespace BookModel;

public abstract class PrintableBook : BorrowableBook, IPrintAction
{
    public PrintableBook(string title, string author, string isbn, int publicationYear, bool canBorrow, bool canPrint) : base(title, author, isbn, publicationYear, canBorrow = true, canPrint = true)
    {

    }
    public void PrintPages(int startPage, int endPage)
    {
        Console.WriteLine($"Book print from {startPage} to {endPage}");
    }
}