using Flowers.Models;
using System.Collections.Generic;

namespace Flowers.ViewModels
{
    public class CreateFlower
    {
        BasketFlower basketFlower;
        public IEnumerable<Flower> Flowers { get; set; }
    }
}
