using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using onlineShopping.DAL;
using onlineShopping.Models;
using onlineShopping.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace onlineShopping.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private UserManager<AppUser> _userManager;

        public HomeController(AppDbContext context , UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public  IActionResult Index()
        {
            ProductVm productVm = new ProductVm();

            productVm.products = _context.product.ToList();
            productVm.color = _context.color.ToList();
            productVm.size = _context.size.ToList();
            productVm.mark = _context.mark.ToList();
            productVm.category = _context.category.ToList();


            return View(productVm);

            
        }

        
    }
}
