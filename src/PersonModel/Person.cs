namespace PersonModel;

public abstract class Person
{
    public string Name { get; set; } = string.Empty;
    public int Id { get; set; }

    public Person(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public override string ToString()
    {
        return $"Person Id: {Id}, Name: {Name}";
    }
}