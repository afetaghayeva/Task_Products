using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task1.Model;

namespace Task1.DataAccess
{
    public class ProductDal : IProductDal
    {
        private readonly List<Product> _products;
        public ProductDal()
        {
            _products = new List<Product>
            {
                new Product {Id = 1, ProductName = "Chai", UnitPrice = 18, UnitsInStock = 30},
                new Product {Id = 2, ProductName = "Chang", UnitPrice = 10, UnitsInStock = 3},
                new Product {Id = 3, ProductName = "Chocolade", UnitPrice = 40, UnitsInStock = 10},
                new Product {Id = 4, ProductName = "Maxilaku", UnitPrice = 40, UnitsInStock = 6},
                new Product {Id = 5, ProductName = "Geitost", UnitPrice = 30, UnitsInStock = 10},
                new Product {Id = 6, ProductName = "Tofu", UnitPrice = 34, UnitsInStock = 12},
            };
        }
        public List<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public void Add(Product product)
        {
            product.Id = _products.Count + 1;
            _products.Add(product);
        }

        public void Update(Product product)
        {
            var updatedProduct = _products.FirstOrDefault(p => p.Id == product.Id);
            var index = _products.IndexOf(updatedProduct);
            _products[index] = product;
        }

        public void Delete(int id)
        {
            var deletedProduct = _products.FirstOrDefault(p => p.Id == id);
            _products.Remove(deletedProduct);
        }
    }
}
