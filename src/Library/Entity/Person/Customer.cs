using PersonModel;
using BookModel;
using Interface;

public class Customer : Person
{
    public Customer(string name) : base(name, PersonModel.Role.Customer)
    {
        Name = name;
    }
}