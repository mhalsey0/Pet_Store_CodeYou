using System;
using Products;

namespace Interface
{
    public interface IProductLogic
    {
        public void AddProduct(Product product);

        public list<Product> GetAllProducts();

        public DogLeash GetDogLeashByName(string name);
    }
}

