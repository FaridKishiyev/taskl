using Flowers.DAL;
using Flowers.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flowers.Areas.Admin.Controllers

{
    [Area("Admin")]
    public class FlowersController : Controller
    {
        private readonly AppDbContext _context;

        public FlowersController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Flower> flowers = _context.FlowerCard.ToList();
            return View(flowers);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if(id == null)
            {
              return  NotFound();
            }
            Flower Category = await _context.FlowerCard.FindAsync(id);
            if (Category == null)
            {
                return NotFound();
            }

            return View(Category);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Flower Category = await _context.FlowerCard.FindAsync(id);
            if (Category == null)
            {
                return NotFound();
            }
            _context.FlowerCard.Remove(Category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            List<FlowerCategory> category = _context.Category.ToList();
            return View(category);  
        }
        [HttpPost]
        public IActionResult Create(string Name,string Desc)
        {
            return View();
        }

        public IActionResult SearchFlower(string search)
        {

            List<Flower> flower = _context.FlowerCard.Where(p => p.Flowername.ToLower().Contains(search.ToLower())).ToList();   

            return PartialView("_Search", flower);
        }
    }
}
