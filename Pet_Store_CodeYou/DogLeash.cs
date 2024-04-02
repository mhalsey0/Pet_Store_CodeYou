public class DogLeash : Product
{
    public DogLeash(string name, decimal price, int quantity, string type) : base(name, price, quantity, type)
    {
    }
    public int LengthInches;
    public string Material;
}