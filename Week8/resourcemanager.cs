using System.Collections.Generic;
namespace two;
public class ResourceManager<T> where T : Resource
{
    private readonly List<T> _resources = new();
    public void Add(T resource)
    {
        _resources.Add(resource);
    }
    public void OpenAll()
    {
        foreach(var r in _resources)
        {
            r.Open();
        }
    }
    public void CloseAll()
    {
        foreach(var r in _resources)
        {
            r.Close();
        }
    }
}