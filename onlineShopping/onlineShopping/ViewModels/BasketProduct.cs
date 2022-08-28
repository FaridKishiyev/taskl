using onlineShopping.Models;

namespace onlineShopping.ViewModels
{
    public class BasketProduct
    {
        public int Id { get; set; }
        public string No { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public int MarkId { get; set; }
        public int ColorId { get; set; }
        public int SizeId { get; set; }
        public int BasketCount { get; set; }
        public string ImageString { get; set; }
        public bool basketBuy { get; set; }
        public double price { get; set; }

        public Category category { get; set; }
        public Mark mark { get; set; }
        public Size size { get; set; }
        public Color color { get; set; }
    }
}
