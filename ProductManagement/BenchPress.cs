namespace ProductManagment
{
    public class BenchPress : Product
    {
        protected string material;
        public string Material
        {
            get => material;
            set
            {
                if (value == null)
                    throw new ArgumentException("Material cannot be null.");
                else
                    material = value;
            }
        }
        protected double maxLoad;
        public double MaxLoad
        {
            get => maxLoad;
            set
            {
                if (value >= 0)
                    maxLoad = value;
                else throw new ArgumentException("MaxLoad cannot be negative.");
            }
        }
        protected bool adjustable;
        public bool Adjustable
        {
            get => adjustable;
            set => adjustable = value;
        }
        protected string type;
        public string Type
        {
            get => type;
            set
            {
                if (value == null)
                    throw new ArgumentException("Type cannot be null");
                else
                    type = value;
            }
        }

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
}