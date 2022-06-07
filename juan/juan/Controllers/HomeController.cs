using Microsoft.AspNetCore.Mvc;

namespace juan.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
