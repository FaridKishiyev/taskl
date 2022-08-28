using Microsoft.AspNetCore.Mvc;
using onlineShopping.DAL;
using onlineShopping.Models;

namespace onlineShopping.Controllers
{
    public class MessageController : Controller
    {
        private readonly AppDbContext _context;

        public MessageController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string fullname, string email, string message)
        {
            Message newMessage = new Message();
            if (email != null || message != null)
            {
               return NotFound();
            }

            newMessage.FullName = fullname;
            newMessage.UserEmail = email;
            newMessage.MessageContent = message;

            _context.message.Add(newMessage);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
