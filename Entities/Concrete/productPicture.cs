namespace Entities.Concrete
{
    public class productPicture
    {
        public int Id { get; set; }
        public string pictureUrl { get; set; }
        public int productId { get; set; }
        public Product product { get; set; }
    }

}
