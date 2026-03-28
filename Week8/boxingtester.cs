using System;
namespace three;

public static class BoxingTester
{
    public static void Test()
    {
        int a = 10;
        Console.WriteLine($"Before boxing: {a}");
        object o = a; //boxing, integer turned into object, in heap
        Console.WriteLine($"After boxing: {o}");
        int b = (int)o; //unboxing, turned into integer, in stack
        Console.WriteLine($"After unboxing: {b}");
    }
}
