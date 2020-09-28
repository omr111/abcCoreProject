using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Reflection;
using System.Text;


namespace Entities.Concrete
{
    public class Product
    {
        public Product()
        {
            supplyDetails = new List<supplyDetail>();
            productPictures = new List<productPicture>();
            orderDetails = new List<orderDetail>();
        }
        public int Id { get; set; }

        public string productName { get; set; }
        public decimal price { get; set; }
        public int count { get; set; }
        public int categoryId { get; set; }
        public string seoUrl { get; set; }
        public bool isInMainPage { get; set; }
        public bool isActive { get; set; }

        public Category category { get; set; }
        public List<supplyDetail> supplyDetails { get; set; }
        public List<productPicture> productPictures { get; set; }
        public List<orderDetail> orderDetails { get; set; }
    }

}
