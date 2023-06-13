using Interface;

namespace BookModel;

public abstract class BorrowableBook : Book, IBorrowAndReturn
{
    public BorrowableBook(string title, string author, string isbn, int publicationYear, bool canBorrow, bool canPrint) : base(title, author, isbn, publicationYear, canBorrow = true, canPrint)
    {

    }
    public void Borrow(IBookBase toBeBorrowedBook)
    {

    }

    public void Return(IBookBase toBeReturnedBook)
    {

    }
}