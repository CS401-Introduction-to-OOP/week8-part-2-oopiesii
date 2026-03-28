using System;
namespace two;
public abstract class Resource
{
    public string Name {get;}
    public bool IsOpen {get; protected set;}
    public Resource(string name)
    {
        Name = name;
        IsOpen = false;
    }
    public abstract void Open();
    public abstract void Close();
}