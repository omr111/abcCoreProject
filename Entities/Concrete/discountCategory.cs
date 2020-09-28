namespace Entities.Concrete
{
    public class discountCategory
    {

        public int discountCouponId { get; set; }
        public DiscountCoupon discountCoupon { get; set; }
        public int categoryId { get; set; }
        public Category category { get; set; }

    }

}
