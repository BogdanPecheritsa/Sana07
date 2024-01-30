using ProductManagement;
using System;

public class BenchPress : Product
{
    public string Material { get; set; }
    public double MaxLoad { get; set; }
    public bool Adjustable { get; set; }
    public string Type { get; set; }

    public BenchPress(string name, double price, int count, string material, double maxLoad, bool adjustable, string type)
        : base(name, price, count)
    {
        Material = material;
        MaxLoad = maxLoad;
        Adjustable = adjustable;
        Type = type;
    }

    public override string Display()
    {
        return $"Bench Press: {Name}, Material: {Material}, Max Load: {MaxLoad} kg, Adjustable: {Adjustable}, Type: {Type}, " +
            $"Price: {Price}, Count: {Count}";
    }
}