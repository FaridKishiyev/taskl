using Flowers.Models;
using System.Collections.Generic;

namespace Flowers.ViewModels
{
    public class HomeViewModel
    {
        public List<Flower> Flowers { get; set; } 
        public List<FlowerCategory> Category { get; set; }
    }
}
