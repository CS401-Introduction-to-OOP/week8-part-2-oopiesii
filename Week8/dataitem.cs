using System.Collections.Generic;
namespace four;
public class DataItem
{
    public string Id { get; set; } = string.Empty;
    public byte[] Payload { get; set; } = Array.Empty<byte>();
    public long GetSize()
    {
        long size = 0;
        foreach (byte b in Payload)
        {
            size += sizeof(byte);       
        }
        return size;
    }
}