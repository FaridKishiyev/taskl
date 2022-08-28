using ClosedXML.Excel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using onlineShopping.DAL;
using onlineShopping.Models;
using onlineShopping.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace onlineShopping.Areas.Admin.Controllers
{
    [Area("admin")]

    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private IWebHostEnvironment _env;

        public ProductController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index(int pageSize = 1)
        {
            int take = 1;
            List<Product> products = new List<Product>();

            products = _context.product.Include(i => i.category).Include(i => i.color)
                 .Include(i => i.mark).Include(i => i.size)
                 .Skip((pageSize - 1) * take).Take(take).ToList();

            Pagination<Product> paginationProducts = new Pagination<Product>();
            if (products == null)
            {
                paginationProducts.PageCount = pageSize - 1;
            }
            else
            {
                paginationProducts.PageCount = pageSize;
            }
            paginationProducts.Items = products;

            paginationProducts.CurrentCount = ((pageSize - 1) * take);

            return View(paginationProducts);
        }

        public IActionResult Created()
        {
            ProductVm productVm = new ProductVm();

            productVm.mark = _context.mark.ToList();
            productVm.size = _context.size.ToList();
            productVm.color = _context.color.ToList();
            productVm.category = _context.category.ToList();

            return View(productVm);
        }

        [HttpPost]

        public IActionResult Created(string productName, string productDesc, double productprice, int productcount, int colorId, int categoryId, int brandId, int sizeId, IFormFile productImage)
        {

            Product product = new Product();
            string randomProductId = Guid.NewGuid().ToString();

            if (!productImage.ContentType.Contains("image"))
            {
                return NotFound();
            }


            string path = _env.WebRootPath;
            string filename = Guid.NewGuid().ToString() + productImage.FileName;
            string result = Path.Combine(path, "assets", "img", filename);

            using (FileStream stream = new FileStream(result, FileMode.Create))
            {
                productImage.CopyTo(stream);
            }

            product.No = randomProductId;
            product.ProductName = productName;
            product.ProductDesc = productDesc;
            product.price = productprice;
            product.Count = productcount;
            product.CategoryId = categoryId;
            product.MarkId = brandId;
            product.SizeId = sizeId;
            product.ColorId = colorId;
            product.ImageString = filename;


            _context.product.Add(product);
            _context.SaveChanges();



            return RedirectToAction(nameof(Index));
        }

        public IActionResult ProductExportExcel()
        {
            List<Product> products = new List<Product>();

            products = _context.product.Include(i => i.category).Include(i => i.color)
                 .Include(i => i.mark).Include(i => i.size)
                 .ToList();

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Məhsul siyahısı");
                worksheet.Cell(1, 1).Value = "Id";
                worksheet.Cell(1, 2).Value = "Məhsul adı";
                worksheet.Cell(1, 3).Value = "Brend";
                worksheet.Cell(1, 4).Value = "Bazada sayı";
                worksheet.Cell(1, 5).Value = "Rəngi";
                worksheet.Cell(1, 6).Value = "Ölçüsü";

                int LineCount = 2;

                foreach (var item in products)
                {
                    worksheet.Cell(LineCount, 1).Value = item.Id;
                    worksheet.Cell(LineCount, 2).Value = item.ProductName;
                    worksheet.Cell(LineCount, 3).Value = item.mark.BrandName;
                    worksheet.Cell(LineCount, 4).Value = item.Count;
                    worksheet.Cell(LineCount, 5).Value = item.color.ColorName;
                    worksheet.Cell(LineCount, 6).Value = item.size.SizeValue;
                    LineCount++;
                }

                using(var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ProductExcel.xlsx");
                }


            }

           
        }
    }
}
