using FirstWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp
{
    public class SeedData
    {
        InventoryModelDbContext _context;
        public SeedData(InventoryModelDbContext context)
        {
            _context = context;
        }
        public void InitialiseData()
        {
            if (!_context.Inventory.Any())
            {
                _context.Inventory.Add(new ProductModel("lettuce", 10.5, 50, "Leafy green"));
                _context.Inventory.Add(new ProductModel("cabbage", 20, 100, "Cruciferous"));
                _context.Inventory.Add(new ProductModel("pumpkin", 30, 30, "Marrow"));
                _context.Inventory.Add(new ProductModel("cauliflower", 10, 25, "Cruciferous"));
                _context.Inventory.Add(new ProductModel("zucchini", 20.5, 50, "Marrow"));
                _context.Inventory.Add(new ProductModel("yam", 30, 50, "Root"));
                _context.Inventory.Add(new ProductModel("spinach", 10, 100, "Leafy green"));
                _context.Inventory.Add(new ProductModel("broccoli", 20.2, 75, "Cruciferous"));
                _context.Inventory.Add(new ProductModel("garlic", 30, 20, "Leafy green"));
                _context.Inventory.Add(new ProductModel("silverbeet", 10, 50, "Marrow"));
                _context.SaveChanges();
            }
        }
    }
}
