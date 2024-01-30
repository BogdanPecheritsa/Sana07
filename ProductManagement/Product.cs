namespace ProductManagement
{
    public abstract class Product
    {
        protected string name;
        public string Name
        {
            get => name;
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Name cannot be null.");
                }
                name = value;
            }
        }
        protected double price;
        public double Price
        {
            get => price;
            set
            {
                if (value > 0)
                    price = value;
                else throw new ArgumentException("Price cannot be negative.");
            }
        }
        protected int count;
        public int Count
        {
            get => Count;
            set
            {
                if (value >= 0)
                    count = value;
                else throw new ArgumentException("Count cannot be negative.");
            }
        }


        public abstract string Display();

        public Product(string name, double price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }
    }
}