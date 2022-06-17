using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace test.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string SpanText { get; set; }
        public string HeadText { get; set; }
        public string SliderDesc { get; set; }
        public string SliderImgUrl { get; set; }

        [NotMapped]
        public IFormFile SlidePhoto { get; set; }
    }
}
