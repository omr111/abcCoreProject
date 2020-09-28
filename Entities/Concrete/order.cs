using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class order
    {
        public order()
        {
            orderDetails = new List<orderDetail>();
        }
        public int Id { get; set; }
        public DateTime orderDate { get; set; }
        public string orderNo { get; set; }
        public string orderDescription { get; set; }
        public int paymentType { get; set; }
        public decimal totalPrice { get; set; }
        public int userId { get; set; }
        public user user { get; set; }
        public List<orderDetail> orderDetails { get; set; }
        public bool status { get; set; }
    }

}
