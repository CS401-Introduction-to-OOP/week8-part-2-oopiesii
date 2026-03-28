using System;
namespace two;
class FileResource : Resource, IDisposable
{
    public FileResource(string name) : base(name)
    {
    }
    public override void Open()
    {
        IsOpen = true;
        Console.WriteLine("File is opened.");
    }
    public override void Close()
    {
        IsOpen = false;
        Console.WriteLine("File is closed.");
    }
    public void Dispose()
    {
        Close();
    }
}