namespace PersonModel;

public abstract class Person
{
    private string _name;
    private int _id;

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
    public int Id
    {
        get
        {
            return _id;
        }
        set
        {
            _id = value;
        }
    }
    public Person(string name, int id)
    {
        _name = name;
        _id = id;
    }

    public override string ToString()
    {
        return $"Person Id: {Id}, Name: {Name}";
    }
}