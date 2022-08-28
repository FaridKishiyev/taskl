using Microsoft.AspNetCore.Identity;

namespace onlineShopping.Models
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }
    }
}
