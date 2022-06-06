using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Flowers.Models
{
    public class FlowerCategory
    {
        public int Id { get; set; }
        [Required]
        public string CategoryName { get; set; }

        public IEnumerable<Flower> Flower { get; set; }
    }
}
