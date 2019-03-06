using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {

        bool FilterByPrice(Product p)
        {
            return (p?.Price ?? 0) >= 20;
        }
        public ViewResult Index()
        {

            ShoppingCart cart
                = new ShoppingCart { Products = Product.GetProducts() };

            Product[] productArray = {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M},
                new Product {Name = "Soccer ball", Price = 19.50M},
                new Product {Name = "Corner flag", Price = 34.95M}
            };

            Func<Product, bool> nameFilter = delegate (Product prod) {
                return prod?.Name?[0] == 'S';
            };

            decimal priceFilterTotal = productArray
                .Filter(FilterByPrice)
                .TotalPrices();
            decimal nameFilterTotal = productArray
                .Filter(nameFilter)
                .TotalPrices();

            return View("Index", new string[] {
                $"Price Total: {priceFilterTotal:C2}",
                $"Name Total: {nameFilterTotal:C2}" });

            /*int i = 0;
            string[] names = new string[7];
            names[i++] = "Bob";
            names[i++] = "Joe";
            names[i++] = "Alice";
            names[i++] = "Jacob";
            names[i++] = "Kindra";
            names[i++] = "Malachi";
            names[i++] = "Michelle";
            //return View("Index", names);
            //return View(names);
            return View("Index");
            
            List<string> results = new List<string>();

            foreach (Product p in Product.GetProducts())
            {
                string name = p?.Name ?? "<No Name>";
                decimal? price = p?.Price ?? 0;
                string relatedName = p?.Related?.Name ?? "<None>";
                bool? instock = p?.InStock ?? false;
                string category = p?.Category;
                //results.Add(string.Format("Name: {0}, Price: {1}", name, price));
                results.Add($"Name: {name}, Price: {price}, Related: {relatedName}, " +
                    $"Instock: {instock}, Category: {category}");
            }

            return View(results);*/
        }
    }
}
