using ProductManagement;
using System;

class Program
{
    static void Main()
    {
        Treadmill treadmill = new Treadmill("ProRunner 2000", 1200.00, 5, true, 10.0, 3, "LCD");
        BenchPress benchPress = new BenchPress("FoldableBench", 199.50, 8, "Metal", 300, true, "Steel");

        Console.WriteLine(treadmill.Display());
        Console.WriteLine(benchPress.Display());
    }
}