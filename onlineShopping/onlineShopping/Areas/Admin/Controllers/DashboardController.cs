using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace onlineShopping.Areas.Admin.Controllers
{
    [Area("admin")]

    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
