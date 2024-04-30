
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Press 1 to add a product, 2 to get a product from the list.");
        Console.WriteLine("Type 'exit' to quit");
        string userInput = Console.ReadLine();

        while (userInput.ToLower() != "exit")
        {
            if (userInput == "1")
            {
                CatFood catFood = new CatFood();
                AddProduct(catFood);
                Console.WriteLine($"{catFood} was added!");
            }
            if (userInput == "2")
            {
                GetAllProducts();
            }
                Console.WriteLine("Press 1 to add a product, 2 to get a product from the list.");
                Console.WriteLine("Type 'exit' to quit");
            userInput = Console.ReadLine();
        }
        var productLogic = new ProductLogic();
    }
}