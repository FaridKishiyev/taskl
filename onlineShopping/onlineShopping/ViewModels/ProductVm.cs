using onlineShopping.Models;
using System.Collections.Generic;

namespace onlineShopping.ViewModels
{
    public class ProductVm
    {
        public List<Color> color = new List<Color>();
        public List<Size> size = new List<Size>();
        public List<Mark> mark = new List<Mark>();
        public List<Category> category = new List<Category>();
        public List<Product> products = new List<Product>();

        public Product product = new Product();

    }
}
