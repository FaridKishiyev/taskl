using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using onlineShopping.DAL;
using onlineShopping.Models;
using onlineShopping.ViewModels;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace onlineShopping.Controllers
{
    public class BasketController : Controller
    {
        private readonly AppDbContext _context;
        private UserManager<AppUser> _userManager;

        public BasketController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("IndexCookie", "Basket");
            }
            List<Basket> baskets = new List<Basket>();
            List<Basket> sendBaskets = new List<Basket>();

            baskets = _context.basket.Include(i => i.Product).ThenInclude(i => i.category).Include(i => i.Product).ThenInclude(i => i.color).Include(i => i.Product).ThenInclude(i => i.mark).Include(i => i.Product).ThenInclude(i => i.size).ToList();

            string inputData = "";
            int count = 0;
            foreach (var item in baskets)
            {
                if (item.UserEmail == _userManager.FindByNameAsync(User.Identity.Name).Result.Email && item.basketBuy == false)
                {
                    count++;
                    sendBaskets.Add(item);
                    inputData += item.ProductId + ",";


                }
            }

            using (MemoryStream memoryStream = new MemoryStream())
            {
                QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
                QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(inputData, QRCodeGenerator.ECCLevel.Q);
                QRCode qRCode = new QRCode(qRCodeData);
                using (Bitmap bitmap = qRCode.GetGraphic(20))
                {
                    bitmap.Save(memoryStream, ImageFormat.Png);
                    ViewBag.QRCode = "data:image/png;base64," + Convert.ToBase64String(memoryStream.ToArray());
                }
            }

            return View(sendBaskets);
        }

        public IActionResult IndexCookie()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Basket");
            }
            BasketCookie basketCookie = new BasketCookie();
            basketCookie.basketProduct = JsonConvert.DeserializeObject<List<BasketProduct>>(Request.Cookies["basket"]);

            basketCookie.products = _context.product.Include(i => i.category).Include(i => i.color).Include(i => i.mark).Include(i => i.size).ToList();


            return View(basketCookie);
        }

        public IActionResult AddBasket(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product product = _context.product.Find(id);

            if (product == null)
            {
                return NotFound();
            }


            if (!User.Identity.IsAuthenticated)
            {

                List<BasketProduct> basketProducts = new List<BasketProduct>();

                string existBasket = Request.Cookies["basket"];

                if (existBasket != null)
                {
                    basketProducts = JsonConvert.DeserializeObject<List<BasketProduct>>(Request.Cookies["basket"]);
                }

                BasketProduct SearchBasket = basketProducts.FirstOrDefault(i => i.Id == product.Id);

                if (SearchBasket == null)
                {
                    if (product.Count < 1)
                    {
                        return Content("bazada kifayet qeder mehsul yoxdu");
                    }
                    BasketProduct basket = new BasketProduct();

                    basket.Id = product.Id;
                    basket.ProductName = product.ProductName;
                    basket.ProductDesc = product.ProductDesc;
                    basket.ImageString = product.ImageString;
                    basket.MarkId = product.MarkId;
                    basket.ColorId = product.ColorId;
                    basket.SizeId = product.SizeId;
                    basket.CategoryId = product.CategoryId;
                    basket.price = product.price;
                    basket.BasketCount = 1;

                    basketProducts.Add(basket);
                }
                else
                {
                    if (product.Count > SearchBasket.BasketCount)
                    {
                        SearchBasket.BasketCount++;
                    }
                    else
                    {
                        return Content("bazada kifayet qeder mehsul yoxdu");
                    }


                }

                Response.Cookies.Append("basket", JsonConvert.SerializeObject(basketProducts), new CookieOptions { MaxAge = TimeSpan.FromDays(30) });
                return RedirectToAction("IndexCookie", "Basket");
            }



            Basket newBasket = new Basket();

            if (User.Identity.IsAuthenticated)
            {
                string userEmail = _userManager.FindByNameAsync(User.Identity.Name).Result.Email;

                List<Basket> userBasketList = _context.basket.Where(b => b.UserEmail == userEmail).ToList();

                Basket userBasket = userBasketList.FirstOrDefault(b => b.ProductId == product.Id);

                if (userBasket == null)
                {
                    if (product.Count < 1)
                    {
                        return Content("bazada kifayet qeder mehsul yoxdu");
                    }

                    newBasket.UserEmail = userEmail;
                    newBasket.ProductId = (int)id;
                    newBasket.Count = 1;

                    _context.basket.Add(newBasket);
                    _context.SaveChanges();
                }

                else
                {
                    if (product.Count > userBasket.Count)
                    {
                        userBasket.Count++;
                        _context.SaveChanges();

                    }
                    else
                    {
                        return Content("bazada kifayet qeder mehsul yoxdu");
                    }

                }




            }

            return RedirectToAction("Index", "Basket");
        }

        public IActionResult ReduceBasket(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            if (!User.Identity.IsAuthenticated)
            {

                List<BasketProduct> basketProducts;

                string existBasket = Request.Cookies["basket"];

                if (existBasket == null)
                {
                    return NotFound();
                }
                else
                {
                    basketProducts = JsonConvert.DeserializeObject<List<BasketProduct>>(Request.Cookies["basket"]);
                }

                BasketProduct SearchBasket = basketProducts.FirstOrDefault(i => i.Id == id);

                if (SearchBasket == null)
                {
                    return NotFound();
                }

                if (SearchBasket.BasketCount > 1)
                {
                    SearchBasket.BasketCount--;
                }
                else
                {
                    return RedirectToAction("IndexCookie", "Basket");
                }


                Response.Cookies.Append("basket", JsonConvert.SerializeObject(basketProducts), new CookieOptions { MaxAge = TimeSpan.FromDays(30) });
                return RedirectToAction("IndexCookie", "Basket");
            }


            Basket newBasket = new Basket();

            if (User.Identity.IsAuthenticated)
            {
                string userEmail = _userManager.FindByNameAsync(User.Identity.Name).Result.Email;

                List<Basket> userBasketList = _context.basket.Where(b => b.UserEmail == userEmail).ToList();

                Basket userBasket = userBasketList.FirstOrDefault(b => b.ProductId == id);

                if (userBasket == null)
                {

                    return NotFound();
                }

                if (userBasket != null && userBasket.Count > 1)
                {
                    userBasket.Count--;
                    _context.SaveChanges();
                }


                return RedirectToAction("Index", "Basket");

            }

            return View();
        }

        public IActionResult RemoveBasket(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            if (!User.Identity.IsAuthenticated)
            {

                List<BasketProduct> basketProducts;

                string existBasket = Request.Cookies["basket"];

                if (existBasket == null)
                {
                    return NotFound();
                }
                else
                {
                    basketProducts = JsonConvert.DeserializeObject<List<BasketProduct>>(Request.Cookies["basket"]);
                }

                BasketProduct SearchBasket = basketProducts.FirstOrDefault(i => i.Id == id);

                if (SearchBasket == null)
                {
                    return NotFound();
                }
                else
                {
                    basketProducts.Remove(SearchBasket);
                }

                Response.Cookies.Append("basket", JsonConvert.SerializeObject(basketProducts), new CookieOptions { MaxAge = TimeSpan.FromDays(30) });
                return RedirectToAction("IndexCookie", "Basket");
            }

            Basket newBasket = new Basket();

            if (User.Identity.IsAuthenticated)
            {
                string userEmail = _userManager.FindByNameAsync(User.Identity.Name).Result.Email;

                List<Basket> userBasketList = _context.basket.Where(b => b.UserEmail == userEmail).ToList();

                Basket userBasket = userBasketList.FirstOrDefault(b => b.ProductId == id);

                if (userBasket == null)
                {
                    return NotFound();
                }

                if (userBasket != null)
                {

                    _context.basket.Remove(userBasket);
                    _context.SaveChanges();
                }


                return RedirectToAction("Index", "Basket");

            }

            return View();
        }

        public IActionResult BuyBasket()
        {

            if (!User.Identity.IsAuthenticated)
            {
                List<BasketProduct> basketProduct = new List<BasketProduct>();
                basketProduct = JsonConvert.DeserializeObject<List<BasketProduct>>(Request.Cookies["basket"]);
                List<Product> productList = _context.product.ToList();
                Product product = new Product();
                foreach (var item in basketProduct)
                {
                    item.basketBuy = true;

                    product = productList.Find(b => b.Id == item.Id);

                    product.Count = product.Count - item.BasketCount;



                }
                _context.SaveChanges();

                Response.Cookies.Append("basket", JsonConvert.SerializeObject(basketProduct), new CookieOptions { MaxAge = TimeSpan.FromDays(30) });
                return RedirectToAction("IndexCookie", "Basket");

            }

            if (User.Identity.IsAuthenticated)
            {
                List<Basket> basket = new List<Basket>();
                string userEmail = _userManager.FindByNameAsync(User.Identity.Name).Result.Email;

                basket = _context.basket.Where(b => b.UserEmail == userEmail).ToList();
                List<Product> productList = _context.product.ToList();
                Product product = new Product();

                foreach (var item in basket)
                {
                    item.basketBuy = true;

                    product = productList.Find(b => b.Id == item.Id);
                    product.Count = product.Count - item.Count;
                }

                _context.SaveChanges();
            }

            return View();
        }

        public IActionResult QrRead()
        {
            return View();
        }

        [HttpPost]
        public IActionResult QrRead(string addBasketQrText)
        {
            if (addBasketQrText == null)
            {
                return Content("bosdu");
            }

            string[] qrProductId = addBasketQrText.Split(",");

            foreach (var itemString in qrProductId)
            {

                if (itemString == "")
                {
                    continue;
                }

                int item = int.Parse(itemString);
                
                Product product = _context.product.Find(item);
                Basket newBasket = new Basket();
                if (User.Identity.IsAuthenticated)
                {
                    string userEmail = _userManager.FindByNameAsync(User.Identity.Name).Result.Email;

                    List<Basket> userBasketList = _context.basket.Where(b => b.UserEmail == userEmail).ToList();

                    Basket userBasket = userBasketList.FirstOrDefault(b => b.ProductId == product.Id);

                    

                    if (userBasket == null)
                    {
                        if (product.Count < 1)
                        {
                            return Content("bazada kifayet qeder mehsul yoxdu");
                        }

                        newBasket.UserEmail = userEmail;
                        newBasket.ProductId = item;
                        newBasket.Count = 1;

                        _context.basket.Add(newBasket);
                        _context.SaveChanges();
                    }

                   

                }
            }





            return RedirectToAction(nameof(Index));
        }
    }
}
