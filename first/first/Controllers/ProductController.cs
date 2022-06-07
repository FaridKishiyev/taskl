using first.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace first.Constrollers
{
    public class ProductController : Controller
    {
        public IActionResult Index(string productId)
        {
            List<Product> products = new List<Product> {
                new Product
                {
                    Id = 1,
                    Name = "Koynek",
                    Description = "zara koynekleridi",
                    Image = "Koynek.jpg",
                    Price = 30
                },
                new Product
                {
                    Id = 2,
                    Name = "Salvar",
                    Description = "Gucci Salvarlaridi",
                    Image = "Salvar.jpg",
                    Price = 70
                },
                new Product
                {
                    Id = 3,
                    Name = "Telfon",
                    Description = "Samsung Telfonudu",
                    Image = "samsung.png",
                    Price = 900
                }
            };

            if (!string.IsNullOrWhiteSpace(productId))
            {
                products = products.FindAll(p => p.Description.ToLower().Contains(productId.ToLower()));
                if (products.Count == 0)
                {
                    return NotFound();
                } 
            }

            return Content(productId);
        }
    }
}
