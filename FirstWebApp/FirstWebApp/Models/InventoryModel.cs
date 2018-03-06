using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Models
{
    public class InventoryModel
    {
        public IEnumerable<ProductModel> ListOfProducts { get; set; }
        public InventoryModel()
        {

        }
            

         
    }
}
