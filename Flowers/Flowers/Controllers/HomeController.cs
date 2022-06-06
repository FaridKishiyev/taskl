using Flowers.DAL;
using Flowers.Models;
using Flowers.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Flowers.Controllers
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
            List<Flower> flowers = _context.FlowerCard.Include(p=>p.Category).ToList();
            List<FlowerCategory> category = _context.Category.ToList();
            HomeViewModel homeVM = new HomeViewModel 
            { 
                Flowers = flowers,
                Category = category,
            };
            return View(homeVM);
        }
    }
}
