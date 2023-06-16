namespace Entity;
public abstract class BaseEntity
{
    public string Id { get; }

    public BaseEntity()
    {
        Id = new Guid().ToString();
    }
}
