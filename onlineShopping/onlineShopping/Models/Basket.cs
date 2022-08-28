namespace onlineShopping.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string UserEmail { get; set; }
        public int Count { get; set; }
        public bool basketBuy { get; set; }

        public Product Product { get; set; }
        public AppUser AppUser { get; set; }

    }
}
