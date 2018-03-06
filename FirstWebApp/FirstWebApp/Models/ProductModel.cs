using System;
using System.ComponentModel.DataAnnotations;

namespace FirstWebApp.Models
{
    public class ProductModel
    {

        [Key]
        public String Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public String Type { get; set; }

        public ProductModel()
        {

        }
        public ProductModel(string name, double price, int quantity, string type)
        {
           
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Type = type;

        }
    }
}
