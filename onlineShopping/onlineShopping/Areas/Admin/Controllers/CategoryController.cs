using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using onlineShopping.DAL;
using onlineShopping.Models;
using System.Collections.Generic;
using System.Linq;

namespace onlineShopping.Areas.Admin.Controllers
{
    [Area("admin")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
           List<Category> categories = _context.category.ToList();
            return View(categories);
        }

        public IActionResult Created()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Created(Category category)
        {
            if (category == null)
            {
                return NotFound();
            }

            Category newCategory= new Category();
            newCategory.Name = category.Name;
            _context.category.Add(newCategory);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
               return NotFound();
            }

            Category DeleteCategory = _context.category.Find(id); 

            if (DeleteCategory == null)
            {
                return NotFound();
            }

            _context.category.Remove(DeleteCategory);
            _context.SaveChanges();
           return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category UpdateCategory = _context.category.Find(id);

            if (UpdateCategory == null)
            {
                return NotFound();
            }
            return View(UpdateCategory);
        }
        
        [HttpPost]
        public IActionResult Update(int? id, Category category)
        {
            if (id==null)
            {
                return NotFound();
            }

            Category UpdateCategory = _context.category.Find(id);

            if (UpdateCategory == null)
            {
                return NotFound();
            }

            UpdateCategory.Name = category.Name;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
    }
}
