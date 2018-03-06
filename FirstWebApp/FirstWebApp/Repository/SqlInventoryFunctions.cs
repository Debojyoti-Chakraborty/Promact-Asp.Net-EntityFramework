using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstWebApp.Models;

namespace FirstWebApp.Repository
{
    public class SqlInventoryFunctions : IInventoryFunctions
    {
        InventoryModelDbContext _context;
        public SqlInventoryFunctions(InventoryModelDbContext context)
        {
            _context = context;
        }
        public void AddProduct(ProductModel product)
        {
            _context.Inventory.Add(product);
            _context.SaveChanges();
        }

        public IEnumerable<ProductModel> GetAll()
        {
            return _context.Inventory;
        }

        public void Remove(string name)
        {
            ProductModel matchedItem=new ProductModel("",0,0,"");
            foreach (var item in _context.Inventory)
            {
                if (item.Name==name)
                {
                    matchedItem = item; 
                }

            }
            _context.Inventory.Remove(matchedItem);

            _context.SaveChanges();
           
        }
        public ProductModel GetProduct(string name)
        {
            ProductModel matchedItem = new ProductModel("", 0, 0, "");
            foreach (var item in _context.Inventory)
            {
                if (item.Name == name)
                {
                    matchedItem = item;
                }

            }
            return matchedItem;
        }
    }
}
