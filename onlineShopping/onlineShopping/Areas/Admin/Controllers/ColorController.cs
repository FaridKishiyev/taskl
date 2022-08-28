using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using onlineShopping.DAL;
using onlineShopping.Models;
using System.Collections.Generic;
using System.Linq;

namespace onlineShopping.Areas.Admin.Controllers
{
    [Area("admin")]
    [Authorize(Roles = "Admin")]
    public class ColorController : Controller
    {
        private readonly AppDbContext _context;

        public ColorController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Color> colors = _context.color.ToList();
            return View(colors);
        }

        public IActionResult Created()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Created(Color color)
        {
            if (color == null)
            {
                return NotFound();
            }

            Color newColor = new Color();

            newColor.ColorName = color.ColorName;
            newColor.ColorCode = color.ColorCode;

            _context.color.Add(newColor);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }

            Color color = _context.color.Find(id);

            if (color == null)
            {
                return NotFound();
            }

            _context.color.Remove(color);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Color color = _context.color.Find(id);

            if (color == null)
            {
                return NotFound();
            }

            return View(color);
        }

        [HttpPost]
        public IActionResult Update(int? id,Color color)
        {


            if (color == null)
            {
                return NotFound();
            }

            Color searchColor = _context.color.Find(id);

            if (color == null)
            {
                return NotFound();
            }


            Color newColor = new Color();

            newColor.ColorName = color.ColorName;
            newColor.ColorCode = color.ColorCode;

            searchColor.ColorName = newColor.ColorName;
            searchColor.ColorCode = newColor.ColorCode;


            _context.SaveChanges();

            return RedirectToAction(nameof(Index));

        }
    }
}
