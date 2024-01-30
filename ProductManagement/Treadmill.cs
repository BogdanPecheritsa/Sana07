using ProductManagement;
using System;

public class Treadmill : Product
{
    protected bool motorized;
    public bool Motorized
    {
        get => motorized;
        set => motorized = value;
    }
    protected double maxSpeed;
    public double MaxSpeed
    {
        get => maxSpeed;
        set
        {
            if (value >= 0)
                maxSpeed = value;
            else throw new ArgumentException("MaxSpeed cannot be negative.");
        }
    }

    protected int inclineLevels;
    public int InclineLevels
    {
        get => inclineLevels;
        set
        {
            if (value >= 0)
                inclineLevels = value;
            else throw new ArgumentException("InclineLevels cannot be negative.");
        }
    }
    protected string displayType;
    public string DisplayType
    {
        get => displayType;
        set
        {
            if (value == null)
                throw new ArgumentException("DisplayType cannot be null.");
          else 
                displayType = value;
        }
    }

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