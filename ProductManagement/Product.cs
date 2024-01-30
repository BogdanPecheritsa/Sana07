namespace ProductManagement
{
    public abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }

        public abstract string Display();

        public Product(string name, double price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }
    }
}