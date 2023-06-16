using Entity;

namespace PersonModel;

public enum Role
{
    Customer,
    Librarian
}

public abstract class Person : BaseEntity
{
    private string _name;
    public Role Role { get; }

    public string Name
    {
        get
        {
            if (_name != null)
            {
                return _name;
            }
            else
            {
                throw new Exception("Name is unavailble");
            }
        }
        set
        {
            if (value == null || value == "")
            {
                throw new Exception("Name cannot be empty");
            }
            else
            {
                _name = value;
            }
        }
    }
    public Person(string name, Role role) : base()
    {
        _name = name;
        Role = role;
    }

    public override string ToString()
    {
        return $"Person Id: {Id}, Name: {Name}";
    }
}