public class ProductLogic 
{
    private List<Product> _products;
    private Dictionary<string, DogLeash> _dogLeashDictionary;
    private Dictionary<string, CatFood> _catFoodDictionary;

    public ProductLogic()
    {
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        if (product is DogLeash)
        {
            _dogLeashDictionary.Add(product as DogLeash);
        } 
        //I don't understand this error CS7036 on the add method. research later
        if (product is CatFood)
        {
            _catFoodDictionary.Add(product as CatFood);
        } 
        else 
        {
        _products.Add(product);
        }
    }

    public DogLeash GetDogLeashByName(string Name);
    {
        return _dogLeash[Name];
    }

    public List<Product> GetAllProducts()
    {
      return _products;   
    }
}