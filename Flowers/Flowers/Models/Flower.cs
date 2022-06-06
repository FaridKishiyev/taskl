namespace Flowers.Models
{
    public class Flower
    {
        public int Id { get; set; }
        public string Flowername { get; set; }
        public string FlowerImg { get; set; }
        public float FlowerPricing { get; set; }
        public string FlowerDescription { get; set; }
        public int Count { get; set; }

        public int FlowerCategoryId { get; set; }
        public FlowerCategory Category { get; set; }
    }
}
