namespace Entity;
public abstract class BaseEntity
{
    public string Id { get; }

    public BaseEntity()
    {
        Id = Guid.NewGuid().ToString();
    }
}
