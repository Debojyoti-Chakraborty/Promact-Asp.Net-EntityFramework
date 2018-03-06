using FirstWebApp.Models;
using FirstWebApp.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        private IInventoryFunctions _listOfProducts;
        public HomeController(IInventoryFunctions listOfProducts)
        {
            _listOfProducts = listOfProducts;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var model = new InventoryModel();
            model.ListOfProducts = _listOfProducts.GetAll();
            return View(model);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(IFormCollection collection)
        {
            ProductModel product = new ProductModel(collection["Name"], System.Convert.ToDouble(collection["Price"]), System.Convert.ToInt16(collection["Quantity"]), collection["Type"]);
            _listOfProducts.AddProduct(product);
            return RedirectToAction("Index","Home");
        }
        public IActionResult Remove()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Remove(string name)
        {
            //Error if string does not match any of the products
            _listOfProducts.Remove(name);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(string name)
        {

            var model = _listOfProducts.GetProduct(name);
            
            
            return View("Edit", model);
        }
        
        [HttpPost]
        public IActionResult Edit(ProductModel product)
        {
            //Error if the name has been changed
            _listOfProducts.Remove(product.Name);
            _listOfProducts.AddProduct(product);
            return RedirectToAction("Index", "Home");
        }
    }
}