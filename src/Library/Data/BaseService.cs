using Entity;

namespace Data;
public abstract class BaseService<T> where T : BaseEntity
{
    public List<T>? collection;

    public IEnumerable<T> GetAll(int limit, int page)
    {
        return collection!.Skip(page * limit).Take(limit).ToArray();
    }

    public T? GetById(string id)
    {
        return collection!.Find(c => c.Id == id);
    }

    public bool DeleteById(string id)
    {
        var item = GetById(id);
        if (item is null)
        {
            return false;
        }
        else
        {
            collection!.Remove(item);
        }
        return true;
    }

    public bool Update(string id, T updated)
    {
        var item = GetById(id);
        if (item is null)
        {
            return false;
        }
        else
        {
            var itemProperties = item.GetType().GetProperties();
            var updateProperties = updated.GetType().GetProperties();

            foreach (var property in itemProperties)
            {
                if (updated.GetType().GetProperty(property.Name) is not null)
                {
                    if (property.CanWrite)
                    {
                        property.SetValue(item, updated.GetType().GetProperty(property.Name)!.GetValue(updated));
                    }
                }
            }
        }
        return true;
    }
}