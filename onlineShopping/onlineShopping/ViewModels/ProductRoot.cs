using onlineShopping.Models;
using System.Collections.Generic;

namespace onlineShopping.ViewModels
{
    public class ProductRoot
    {
        public List<Product> products = new List<Product>();
        public Product product = new Product();
        public string root;
    }
}
