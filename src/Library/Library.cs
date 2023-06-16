using BookModel;
using PersonModel;

namespace LibraryManagement;

public class Library
{
    private List<Book>? _books { get; set; }
    private List<Book>? _borrowedBooks { get; set; }
    private List<Person>? _people { get; set; }

    public Library()
    {
        _books = new List<Book>();
        _borrowedBooks = new List<Book>();
    }


    public void BorrowBook(Person person, Book book)
    {
        if (person.Role == PersonModel.Role.Customer)
        {
            if (book.CanBorrow)
            {
                _borrowedBooks!.Add(book);
                Console.WriteLine($"Borrowed {book.Title} successfully!");
            }
            else
            {
                throw new Exception($"Borrowed {book.Title} cannot be borrowed!");
            }
        }
        else
        {
            throw new Exception("You do not have the right to borrow book!");
        }
    }

    public void ReturnBook(Person person, Book book)
    {
        if (person.Role == PersonModel.Role.Customer)
        {
            if (_borrowedBooks!.Contains(book))
            {
                _borrowedBooks!.Remove(book);
                Console.WriteLine($"Returned {book.Title} successfully!");
            }
            else
            {
                throw new Exception($"{book.Title} haven't been borrowed!");
            }
        }
        else
        {
            throw new Exception("You do not have the right to return book!");
        }
    }

    public void PrintListBorrowedBooks()
    {
        if (_borrowedBooks != null)
        {
            foreach (Book book in _borrowedBooks)
            {
                book.PrintInfo();
            }
        }
        else
        {
            Console.WriteLine("There is no borrowed book!");
        }
    }

    public void AddBook(Person person, Book book)
    {
        if (person.Role == PersonModel.Role.Librarian)
        {
            _books!.Add(book);
            Console.WriteLine("Added successfully!");
        }
        else
        {
            throw new Exception("You do not have the right to add book!");
        }
    }
    public void RemoveBook(Person person, string id)
    {
        if (person.Role == PersonModel.Role.Librarian)
        {
            int itemIndex = _books!.FindIndex(book => book.Id == id);
            if (itemIndex == -1)
            {
                _books.RemoveAt(itemIndex);
                Console.WriteLine("Removed successfully!");
            }
            else
            {
                throw new Exception("The book does not exist");
            }
        }
        else
        {
            throw new Exception("You do not have the right to remove book!");
        }
    }
    public void EditBook(Person person, Book updatedBook)
    {
        if (person.Role == PersonModel.Role.Librarian)
        {
            int originalBookIndex = _books!.FindIndex(book => book.Id == updatedBook.Id);
            _books[originalBookIndex] = updatedBook;
            Console.WriteLine("Edited successfully!");

        }
        else
        {
            throw new Exception("You do not have the right to edit book!");
        }
    }
}