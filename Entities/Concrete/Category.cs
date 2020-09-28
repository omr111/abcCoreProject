using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Category
    {
        public Category()
        {
            discountCategories =new List<discountCategory>();
            Products = new List<Product>();
        }
        public int Id { get; set; }
        public string categoryName { get; set; }
        public bool isActive { get; set; }

        public List<Product> Products { get; set; }
        public List<discountCategory> discountCategories { get; set; }

    }

}
