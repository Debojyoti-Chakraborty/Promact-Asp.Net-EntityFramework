using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstWebApp.Models;

namespace FirstWebApp.Repository
{
    public interface IInventoryFunctions
    {
         IEnumerable<ProductModel> GetAll();

         void AddProduct(ProductModel product);

         void Remove(String name);

        ProductModel GetProduct(String name);
         
    }
}
