namespace Entities.Concrete
{
    public class orderDetail
    {
        public int Id { get; set; }
        public int productCount { get; set; }
        public decimal productPrice { get; set; }
        public int orderId { get; set; }
        public order order { get; set; }
        public int productId { get; set; }
        public Product product { get; set; }
    }

}
