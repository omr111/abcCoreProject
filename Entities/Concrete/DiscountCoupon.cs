using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class DiscountCoupon
    {
        public DiscountCoupon()
        {
            discountCategories = new List<discountCategory>();
        }
        public int Id { get; set; }
        public string couponNumber { get; set; }
        public DateTime? expirationCoupon { get; set; }
        public bool isActive { get; set; }

        public List<discountCategory> discountCategories { get; set; }
        public bool status { get; set; }

    }

}
