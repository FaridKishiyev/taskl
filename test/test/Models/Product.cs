using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace test.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public string ProductDiscountPrice { get; set; }
        public string ProductImgUrl { get; set; }

        [NotMapped]
        public IFormFile ProductPhoto { get; set; }
    }
}
