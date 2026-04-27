namespace ConsoleApp_Day_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            
            inventory.AddProduct(new Product { Name = "AC", Price = 500000, Quantity = 10 });
            inventory.AddProduct(new Product { Name = "Washing Machine", Price = 20000, Quantity = 20 });

            
            Console.WriteLine("Accessing products:");
            inventory[0].Display();
            inventory[1].Display();

            
            inventory[0].Price = 55000;
            inventory[0].Quantity = 8;

            Console.WriteLine("\nAfter modification:");
            inventory[0].Display();

           
            try
            {
                inventory[1].Price = -100; 
            }
            catch (Exception e)
            {
                Console.WriteLine("\nError: " + e.Message);
            }
        }
    }
}
