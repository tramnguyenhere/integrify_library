using Interface;
using BookModel;

namespace PersonModel;

public class Librarian : Person
{
    public Librarian(string name) : base(name, PersonModel.Role.Librarian)
    {

    }
}