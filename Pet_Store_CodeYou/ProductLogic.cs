

public class ProductLogic : IProductLogic
{
    private List<Product> _products;
    private Dictionary<string, DogLeash> _dogLeashDictionary;
    private Dictionary<string, CatFood> _catFoodDictionary;
//Errors here saying objects above do not exist in this context
    AddProduct(new Product { Name = "Leather Leash", Price = 26.99M, QuantityOnHand = 5 })

    public ProductLogic()
    {
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        if (product is DogLeash)
        {
            _dogLeashDictionary.Add(product.Name, product as DogLeash);
        }
        if (product is CatFood)
        {
            _catFoodDictionary.Add(product.Name, product as CatFood);
        }
        else
        {
            _products.Add(product);
        }
    }

    public DogLeash GetDogLeashByName(string Name)
    {
        try 
        {  
            return _dogLeashDictionary[Name];
        }
        catch (Exception) 
        {
            return null;
        }
    }

    public List<Product> GetAllProducts()
    {
        return _products;
    }
}

public interface IProductLogic
{
}