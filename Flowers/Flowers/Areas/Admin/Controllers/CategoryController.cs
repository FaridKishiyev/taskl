using Flowers.DAL;
using Flowers.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flowers.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<FlowerCategory> category = _context.Category.ToList();
            return View(category);
            
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            FlowerCategory Category = await _context.Category.FindAsync(id);
            if (Category == null)
            {
                return NotFound();
            }
            _context.Category.Remove(Category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(FlowerCategory category)
        {
            //if (ModelState.IsValid)
            //{
            //    return View();
            //}
            FlowerCategory newcategory = new FlowerCategory();
            newcategory.CategoryName = category.CategoryName;
            _context.Category.Add(newcategory);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FlowerCategory category = await _context.Category.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int? id, FlowerCategory category)
        {
            if (id == null)
            {
                return NotFound();
            }

            FlowerCategory Category = await _context.Category.FindAsync(id);

            if (Category == null)
            {
                return NotFound();
            }

            Category.CategoryName = category.CategoryName;

            await _context.SaveChangesAsync(); 

            return View();
        }
    }
}
