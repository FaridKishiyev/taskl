using fiorello.DAL;
using fiorello.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace fiorello.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]

    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;


        public DashboardController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Flowers> flowers = _context.Flowers.ToList();
            return View(flowers);
        }
    }
}
