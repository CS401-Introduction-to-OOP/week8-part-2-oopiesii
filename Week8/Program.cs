using System;
namespace four;
class Program
{
    public static void Main()
    {
        DataContainer<DataItem> container = new DataContainer<DataItem>();

        for (int i = 0; i < 10000; i++)
        {
            DataItem item = new DataItem
            {
                Id = $"item-{i}",
                Payload = new byte[1024]
            };
            container.AddItem(item);
        }

        Console.WriteLine($"Total size before GC: {container.GetTotalSize()} bytes");

        GC.Collect();
        Console.WriteLine("GC.Collect() was called.");
        Console.WriteLine($"Total size after GC: {container.GetTotalSize()} bytes");
    }
    
}