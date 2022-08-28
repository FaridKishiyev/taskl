using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using onlineShopping.DAL;
using onlineShopping.Models;
using onlineShopping.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace onlineShopping.Controllers
{
    public class ProductListController : Controller
    {
        private readonly AppDbContext _context;
        private IWebHostEnvironment _env;

        public ProductListController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        
        public IActionResult Index(int pageSize = 1)
        {
            int take = 1;
            ProductRoot productRoot = new ProductRoot();

            productRoot.products = _context.product.Include(i => i.category).Include(i => i.color)
                .Include(i => i.mark).Include(i => i.size)
                .Skip((pageSize - 1) * take).Take(take)
                .ToList();
            productRoot.root = _env.WebRootPath;

            Pagination<Product> paginationProducts = new Pagination<Product>();
            paginationProducts.imgRoot = _env.WebRootPath;
            if (productRoot.products == null)
            {
                paginationProducts.PageCount = pageSize - 1;
            }
            else
            {
                paginationProducts.PageCount = pageSize;
            }
            paginationProducts.Items = productRoot.products;

            paginationProducts.CurrentCount = ((pageSize - 1) * take);

            return View(paginationProducts);
        }

        public IActionResult Detail(int? id)
        {
            ProductRoot productRoot = new ProductRoot();

            productRoot.product = _context.product.Include(i => i.category).Include(i => i.color).Include(i => i.mark).Include(i => i.size).FirstOrDefault(p=>p.Id ==id);
            productRoot.root = _env.WebRootPath;

            return View(productRoot);
        }

        public IActionResult Filter(string filterCat = null ,string filterSize = null, string filterBrand = null, string filterColor = null)
        {
            ProductRoot productRoot = new ProductRoot();
            ProductRoot sendProductRoot = new ProductRoot();

            productRoot.products = _context.product.Include(i => i.category).Include(i => i.color).Include(i => i.mark).Include(i => i.size).ToList();
            productRoot.root = _env.WebRootPath;
            sendProductRoot.root = _env.WebRootPath;



            foreach (var item in productRoot.products)
            {
                if ((filterCat == null || item.category.Name == filterCat) && (filterBrand == null || item.mark.BrandName == filterBrand) && (filterColor == null || item.color.ColorName == filterColor) && (filterSize == null || item.size.SizeValue == filterSize))
                {
                    sendProductRoot.products.Add(item);
                }
            }

            return View(sendProductRoot);
        }
    }
}
