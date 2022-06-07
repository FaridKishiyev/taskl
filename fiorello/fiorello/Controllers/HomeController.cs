using fiorello.DAL;
using fiorello.Models;
using fiorello.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace fiorello.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Flowers> flowers = _context.Flowers.Take(3).ToList();
            HomeViewModel homeVM = new HomeViewModel
            {
                Flowers = flowers
            };

            return View(homeVM);
        }

        public IActionResult LoadMore()
        {
            return Json(new
            {
                name = "fff"
            });
        }
    }
}
