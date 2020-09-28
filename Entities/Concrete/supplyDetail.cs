namespace Entities.Concrete
{
    public class supplyDetail
    {
        public int Id { get; set; }
        public int productCount { get; set; }
        public decimal productPrice { get; set; }
        public int supplyId { get; set; }
        public supply supply { get; set; }
        public int productId { get; set; }
        public Product product { get; set; }
        public bool status { get; set; }

    }

}
