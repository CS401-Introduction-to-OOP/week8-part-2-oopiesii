using System;
namespace two;
class Program
{
    public static void Main()
    {
        FileResource file = new FileResource("report.txt");
        NetworkResource network = new NetworkResource("api.company.local");
        ResourceManager<Resource> manager = new ResourceManager<Resource>();
        manager.Add(network);
        manager.Add(file);
        manager.OpenAll();
        file.Dispose();
        manager.CloseAll();
        Console.WriteLine("Done.");
    }
    
}