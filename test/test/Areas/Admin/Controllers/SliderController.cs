using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using test.DAL;
using test.Models;

namespace test.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private AppDbContext _context;
        private IWebHostEnvironment _env;
        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Slider> sliderList = _context.Sliders.ToList();
            return View(sliderList);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Slider slider = _context.Sliders.FirstOrDefault(x => x.Id == id);
            if (slider == null)
            {
                return NotFound();
            }

            return View(slider);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Slider slider = _context.Sliders.FirstOrDefault(x => x.Id == id);
            if (slider == null)
            {
                return NotFound();
            }

            _context.Sliders.Remove(slider);
            _context.SaveChanges();

            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (slider==null)
            {
                return NotFound();
            }

            if (!slider.SlidePhoto.ContentType.Contains("image"))
            {
                return NotFound();
            }

            string path = _env.WebRootPath;
            string fileName = Guid.NewGuid().ToString()+ slider.SlidePhoto.FileName;
            string result = Path.Combine(path, "assets", "img", "slider", fileName);

            using (FileStream stream = new FileStream(result, FileMode.Create))
            {
                await slider.SlidePhoto.CopyToAsync(stream);
            }

            Slider newSlider = new Slider();

            newSlider.SpanText = slider.SpanText;
            newSlider.SliderDesc = slider.SliderDesc;
            newSlider.HeadText = slider.HeadText;
            newSlider.SliderImgUrl = fileName;
            _context.Sliders.Add(newSlider);
            _context.SaveChanges();
            return View();
        }

        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Slider slider = _context.Sliders.FirstOrDefault(x => x.Id == id);
            if (slider == null)
            {
                return NotFound();
            }

            return View(slider);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Slider slider,int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            if (slider == null)
            {
                return NotFound();
            }

            if (!slider.SlidePhoto.ContentType.Contains("image"))
            {
                return NotFound();
            }

            Slider newSlider = _context.Sliders.FirstOrDefault(s => s.Id == id);

            string path = _env.WebRootPath;
            string fileName = Guid.NewGuid().ToString() + slider.SlidePhoto.FileName;
            string result = Path.Combine(path, "assets", "img", "slider", fileName);

            using (FileStream stream = new FileStream(result, FileMode.Create))
            {
                await slider.SlidePhoto.CopyToAsync(stream);
            }

            newSlider.SpanText = slider.SpanText;
            newSlider.SliderDesc = slider.SliderDesc;
            newSlider.HeadText = slider.HeadText;
            newSlider.SliderImgUrl = fileName;
            _context.SaveChanges();
            return View();
        }
    }
}
