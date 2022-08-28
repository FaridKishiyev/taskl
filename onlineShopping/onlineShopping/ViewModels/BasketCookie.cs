using onlineShopping.Models;
using System.Collections.Generic;

namespace onlineShopping.ViewModels
{
    public class BasketCookie
    {
        public List<Product> products { get; set; }
        public List<BasketProduct> basketProduct { get; set; }
    }
}
