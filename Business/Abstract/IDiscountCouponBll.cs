using Core.DataResult.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDiscountCouponBll
    {
        IDataResult<List<DiscountCoupon>> getAll();
        IDataResult<List<DiscountCoupon>> getAllByCategoryId(int catId);
       
        IDataResult<DiscountCoupon> getOneById(int id);
        IResult addDiscountCoupon(DiscountCoupon discountCoupon);
        IResult updateDiscountCoupon(DiscountCoupon discountCoupon);
        IResult deleteDiscountCouponById(int id);
        IResult deleteDiscountCouponByEntity(DiscountCoupon discountCoupon);

    }
}
