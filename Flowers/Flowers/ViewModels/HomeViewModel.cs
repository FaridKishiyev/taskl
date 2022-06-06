using Flowers.Models;
using System.Collections.Generic;

namespace Flowers.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Flower> Flowers { get; set; } 
        public IEnumerable<FlowerCategory> Category { get; set; }
    }
}
