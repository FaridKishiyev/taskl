using Microsoft.AspNetCore.Mvc;

namespace first.Constrollers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
