using ProductManagement;
using System;

public class Treadmill : Product
{
    public bool Motorized { get; set; }
    public double MaxSpeed { get; set; }
    public int InclineLevels { get; set; }
    public string DisplayType { get; set; }

    public Treadmill(string name, double price, int count, bool motorized, double maxSpeed, int inclineLevels, string displayType)
        : base(name, price, count)
    {
        Motorized = motorized;
        MaxSpeed = maxSpeed;
        InclineLevels = inclineLevels;
        DisplayType = displayType;
    }

    public override string Display()
    {
        return $"Treadmill: {Name}, Motorized: {Motorized}, Max Speed: {MaxSpeed} mph, Incline Levels: {InclineLevels}, " +
            $"Display Type: {DisplayType}, Price: {Price}, Count: {Count}";
    }
}