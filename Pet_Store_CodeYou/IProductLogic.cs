using System;
using Product;

namespace Interface
{
    public interface IProductLogic
    {
        public void AddProduct(Product product);

        public List<Product> GetAllProducts();

        public DogLeash GetDogLeashByName(string name);
    }
}

