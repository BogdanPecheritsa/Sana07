using System;

namespace ProductManagement
{
    public class ShoppingCart
    {
        protected List<Product> products;

        public ShoppingCart()
        {
            products = new List<Product>();
        }

        public void AddToCart(Product product)
        {
            if (product != null)
            {
                products.Add(product);
                Console.WriteLine($"{product.Name} added to the shopping cart.");
            }
            else
            {
                Console.WriteLine("Cannot add a null product to the shopping cart.");
            }
        }

        public void PrintCartInfo()
        {
            Console.WriteLine("Shopping Cart Contents:");

            foreach (var product in products)
            {
                Console.WriteLine(product.Display());
            }
        }

        public double CalculateTotal()
        {
            return products.Sum(product => product.Price * product.Count);
        }
    }
}