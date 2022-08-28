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
    public class SizeController : Controller
    {
        private readonly AppDbContext _context;

        public SizeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Size> sizes = _context.size.ToList();
            return View(sizes);
        }

        public IActionResult Created()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Created(Size size)
        {
            if (size == null)
            {
                return NotFound();
            }

            Size SearchSize = _context.size.FirstOrDefault(s=> s.SizeValue == size.SizeValue);

            if (SearchSize != null)
            {
                return NotFound();
            }

            Size newSize = new Size();
            newSize.SizeValue = size.SizeValue;
            _context.size.Add(newSize);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Size DeleteSize = _context.size.Find(id);

            if (DeleteSize == null)
            {
                return NotFound();
            }

            _context.size.Remove(DeleteSize);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Size UpdateSize = _context.size.Find(id);

            if (UpdateSize == null)
            {
                return NotFound();
            }
            return View(UpdateSize);
        }

        [HttpPost]
        public IActionResult Update(int? id, Size size)
        {
            if (id == null)
            {
                return NotFound();
            }

            Size SearchSize = _context.size.FirstOrDefault(s => s.SizeValue == size.SizeValue);

            if (SearchSize != null)
            {
                return NotFound();
            }

            Size UpdateSize = _context.size.Find(id);

            if (UpdateSize == null)
            {
                return NotFound();
            }

            UpdateSize.SizeValue = size.SizeValue;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
    }
}
