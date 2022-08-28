using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using onlineShopping.Helpers;
using onlineShopping.Models;
using onlineShopping.ViewModels;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace onlineShopping.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;
        private RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,
           RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid) { return View(); }
            AppUser newUser = new AppUser();
            newUser.FullName = register.Fullname;
            newUser.UserName = register.Username;
            newUser.Email = register.Email;


            

            IdentityResult result = await _userManager.CreateAsync(newUser, register.Password);

            if (result.Succeeded)
            {
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(newUser);
                var link = Url.Action(nameof(VerifyEmail), "Account", new { userId = newUser.Id, code }, Request.Scheme , Request.Host.ToString());
                
                MailMessage msg = new MailMessage();
                msg.Subject = "Asp.Net Send Mail";
                msg.From = new MailAddress("feridferidaztu@gmail.com", "Cayudan");
                msg.To.Add(new MailAddress(newUser.Email, "Sedrike"));
                msg.Body = "Linkə Daxil Olun <br>" + $"<a href=\"{link}\">>-Bura tıkla-<</a>" ;
                msg.IsBodyHtml = true;
                msg.Priority = MailPriority.High;
                // Host ve Port Gereklidir!
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                // Güvenli bağlantı gerektiğinden kullanıcı adı ve şifrenizi giriniz.
                NetworkCredential AccountInfo = new NetworkCredential("feridferidaztu@gmail.com", "vpxymptkxizzdmkm");
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = AccountInfo;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(msg);

                return Content("Email təsdiqləmə linki poçt ünvanına göndərildi. Xahiş edirik poçt ünvanınızı yoxlayın.");
            }
            else
            {

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);

                }
                return View(register);
            }

            await _userManager.AddToRoleAsync(newUser, Roles.Member.ToString());


            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> VerifyEmail(string userId, string code)
        {
            var user = _userManager.FindByIdAsync(userId);

            if (user == null) { return BadRequest(); }

            var result = await _userManager.ConfirmEmailAsync(await user,code);


            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Login(string emailAdres, string password)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            AppUser logUser = await _userManager.FindByEmailAsync(emailAdres);

            if (logUser.EmailConfirmed == false)
            {
                return Content("Təsdiqlənməmiş User");
            }

            if (logUser == null)
            {
                ModelState.AddModelError("", "Parol or Email wrong");
                return View();
            }

            SignInResult result = await _signInManager.PasswordSignInAsync(logUser, password, true, true);

            if (result.IsLockedOut)
            {
                ModelState.AddModelError("", "You lockedOut");
                return View();
            }

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Parol or Email wrong");
                return View();
            }

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

       


        public async Task CreateRole()
        {
            foreach (var item in Enum.GetValues(typeof(Roles)))
            {
                if (!await _roleManager.RoleExistsAsync(item.ToString()))
                {
                    await _roleManager.CreateAsync(new IdentityRole { Name = item.ToString() });
                }
            }
        }

    }
}
