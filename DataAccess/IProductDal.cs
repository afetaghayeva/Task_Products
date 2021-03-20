using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task1.Model;

namespace Task1.DataAccess
{
    public interface IProductDal
    {
        List<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}
