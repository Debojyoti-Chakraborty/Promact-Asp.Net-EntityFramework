using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Models
{
    public class InventoryModelDbContext : DbContext
    {
        public InventoryModelDbContext(DbContextOptions options) : base(options)
        {
            
        }

    

        public DbSet<ProductModel> Inventory { get; set; }
    }
}
