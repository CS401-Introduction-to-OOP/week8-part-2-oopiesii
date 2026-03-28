using System;
namespace three;
class Program
{
    public static void Main()
    {
        Point p1 = new Point { X = 1, Y = 2 };
        Point p2 = p1;
        p2 = new Point { X = 100, Y = 200 };
        p1.Print();
        p2.Print();
        PointRef r1 = new PointRef { X = 1, Y = 2 };
        PointRef r2 = r1;
        r2 = new PointRef { X = 1000, Y = 20 };
        r1.Print();
        r2.Print();
        
        BoxingTester.Test();
    }
    
}