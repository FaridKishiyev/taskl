using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using onlineShopping.DAL;
using onlineShopping.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace onlineShopping.Areas.Admin.Controllers
{
    [Area("admin")]
    [Authorize(Roles ="Admin")]
    public class BrandController : Controller
    {
        private readonly AppDbContext _context;
        private IWebHostEnvironment _env;

        public BrandController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            List<Mark> brands = _context.mark.ToList();
            return View(brands);
        }

        public IActionResult Created()
        {
            return View();
        }
        
        [HttpPost]

        public IActionResult Created(Mark brand)
        {
            if (brand == null)
            {
                return NotFound();
            }

            Mark searchMark = _context.mark.FirstOrDefault(b => b.BrandName == brand.BrandName);

            if (searchMark != null)
            {
                return NotFound();
            }


            Mark newMark = new Mark();

           

            if (!brand.ImageUrl.ContentType.Contains("image"))
            {
                return NotFound();
            }


            string path = _env.WebRootPath;
            string filename = Guid.NewGuid().ToString() + brand.ImageUrl.FileName;
            string result = Path.Combine(path, "assets", "img", filename);

            using (FileStream stream = new FileStream(result, FileMode.Create))
            {
                brand.ImageUrl.CopyTo(stream);
            }


            newMark.BrandName = brand.BrandName;
            newMark.BrandDesc = brand.BrandDesc;
            newMark.ImageString = filename;

            _context.mark.Add(newMark);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));

        }

        public IActionResult Delete(int? id)
        {

            if (id==null)
            {
                return NotFound();
            }

            Mark searchBrand = _context.mark.FirstOrDefault(b => b.Id == id); 

            if (searchBrand == null)
            {
                return NotFound();
            }

            _context.mark.Remove(searchBrand);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detail(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            Mark searchBrand = _context.mark.FirstOrDefault(b => b.Id == id);

            if (searchBrand == null)
            {
                return NotFound();
            }

            return View(searchBrand);
        }

        public IActionResult Update(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            Mark searchBrand = _context.mark.FirstOrDefault(b => b.Id == id);

            if (searchBrand == null)
            {
                return NotFound();
            }

            return View(searchBrand);
        }

        [HttpPost]
        public IActionResult Update(int? id, Mark brand)
        {
            string image = "";

            if (id == null)
            {
                return NotFound();
            }

            Mark searchBrand = _context.mark.FirstOrDefault(b => b.Id == id);

            if (searchBrand == null)
            {
                return NotFound();
            }

            if (brand.ImageString != null)
            {
                if (!brand.ImageUrl.ContentType.Contains("image"))
                {
                    return NotFound();
                }


                string path = _env.WebRootPath;
                string filename = Guid.NewGuid().ToString() + brand.ImageUrl.FileName;
                string result = Path.Combine(path, "assets", "img", filename);

                using (FileStream stream = new FileStream(result, FileMode.Create))
                {
                    brand.ImageUrl.CopyTo(stream);
                }

                image = filename;
            }


            if (brand.ImageString == null)
            {
               
            }
            searchBrand.BrandName = brand.BrandName;
            searchBrand.BrandDesc = brand.BrandDesc;
            searchBrand.ImageString = image;

            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

    }
}
