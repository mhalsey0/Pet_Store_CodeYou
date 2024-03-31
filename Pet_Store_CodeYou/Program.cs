using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Press 1 to add a product");
        Console.WriteLine("Type 'exit' to quite");
        string userInput = Console.ReadLine();

        while (userInput.ToLower() != "exit")
        {
            if (userInput == "1")
            {
                CatFood catFood = new CatFood();
                Console.WriteLine(JsonSerializer.Serialize(catFood));
            }
            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Type 'exit' to quite");
            userInput = Console.ReadLine();
        }

}
}