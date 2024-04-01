using System.Text.Json;

public class CatFood(string name, decimal price,int quantity,string type,double weight,bool kittenFood) : Product(name,price,quantity,type)
{
    public double WeightPounds => weight;
    public bool KittenFood => kittenFood;
    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}