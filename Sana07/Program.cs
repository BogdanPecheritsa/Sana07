namespace ProductManagment
{
    class Program
    {
        static void Main()
        {
            Treadmill treadmill = new Treadmill("ProRunner 2000", 1200.00, 5, true, 10.0, 3, "LCD");
            BenchPress benchPress = new BenchPress("FoldableBench", 199.50, 8, "Metal", 300, true, "Steel");
            Dumbbell dumbbell = new Dumbbell("AdjustableDumbbell", 299.99, 10, 50.0, "Metal", "Textured", true);

            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddToCart(treadmill);
            shoppingCart.AddToCart(benchPress);
            shoppingCart.AddToCart(dumbbell);

            shoppingCart.PrintCartInfo();
            Console.WriteLine($"Total Price: {shoppingCart.CalculateTotal()}");
        }
    }
}