using Flowers.DAL;
using Flowers.Models;
using Flowers.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flowers.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class BasketController : Controller
    {
        private readonly AppDbContext _context;

        public BasketController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Addbasket(int? id)
        {
            if (id==null)
            {
                return Content(id.ToString());
            }
            Flower dbFlower = await _context.FlowerCard.FindAsync(id);
            if (dbFlower == null)
            {
                return Content("tapilmadi");
            }

            string existBasket = Request.Cookies["basket"];
            List<BasketFlower> flower;
            if (existBasket==null)
            {
                 flower = new List<BasketFlower>();
                

            }
            else
            {
                flower = JsonConvert.DeserializeObject<List<BasketFlower>>(Request.Cookies["Basket"]);
               
            }
            BasketFlower existbasketFlower = flower.FirstOrDefault(x => x.Id == dbFlower.Id);
            if (existbasketFlower == null)
            {
                BasketFlower basketFlower = new BasketFlower();
                basketFlower.Id = dbFlower.Id;
                basketFlower.Flowername = dbFlower.Flowername;
                basketFlower.FlowerPricing = dbFlower.FlowerPricing;
                basketFlower.FlowerImg = dbFlower.FlowerImg;
                basketFlower.FlowerDescription = dbFlower.FlowerDescription;
                basketFlower.Count = 1;
                flower.Add(basketFlower);
            }
            else
            {
                existbasketFlower.Count++;
            }


            Response.Cookies.Append("Basket", JsonConvert.SerializeObject(flower), new CookieOptions {MaxAge= TimeSpan.FromMinutes(30) });
            return RedirectToAction("Index","Home", new { area = "default" });
        }

        public IActionResult DeleteBasket(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            List<BasketFlower> flower = JsonConvert.DeserializeObject<List<BasketFlower>>(Request.Cookies["Basket"]);
            BasketFlower searchBasket = flower.FirstOrDefault(b => b.Id == id);
            if (searchBasket == null)
            {
                return NotFound();
            }
            flower.Remove(searchBasket);
            Response.Cookies.Append("Basket", JsonConvert.SerializeObject(flower), new CookieOptions { MaxAge = TimeSpan.FromMinutes(30) });
            return RedirectToAction(nameof(Basket));
        }


        public IActionResult Basket()
        {
            List<BasketFlower> flower =  JsonConvert.DeserializeObject<List<BasketFlower>>(Request.Cookies["Basket"]);
            return View(flower);
        }

        

    }
}
