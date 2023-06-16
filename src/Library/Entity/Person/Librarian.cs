using Interface;
using BookModel;

namespace PersonModel;

public class Librarian : Person
{
    public Librarian(string name, int id) : base(name, PersonModel.Role.Librarian)
    {

    }
}