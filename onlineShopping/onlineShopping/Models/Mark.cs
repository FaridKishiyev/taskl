using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace onlineShopping.Models
{
    public class Mark
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string BrandDesc { get; set; }
        public string ImageString { get; set; }



        [NotMapped]
        public IFormFile ImageUrl { get; set; }



    }
}
