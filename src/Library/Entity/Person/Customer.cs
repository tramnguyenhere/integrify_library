using BookModel;
using Interface;

namespace PersonModel;

public class Customer : Person
{
    public Customer(string name) : base(name, PersonModel.Role.Customer)
    {
        Name = name;
    }
}