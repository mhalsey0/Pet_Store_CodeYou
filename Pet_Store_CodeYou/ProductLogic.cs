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
            _dogLeashDictionary.Add(product.Name, product as DogLeash);
        }
        /*I know understand this error is saying that I
        provided a key but no value. Product is the value
        but what is the key for this exercise? */

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
        return _dogLeashDictionary[Name];
    }

    public List<Product> GetAllProducts()
    {
        return _products;
    }
}