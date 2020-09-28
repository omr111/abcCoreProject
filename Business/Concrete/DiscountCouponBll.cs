using Business.Abstract;
using Core.DataResult.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class DiscountCouponBll : IDiscountCouponBll
    {
        public IResult addDiscountCoupon(DiscountCoupon discountCoupon)
        {
            throw new NotImplementedException();
        }

        public IResult deleteDiscountCouponByEntity(DiscountCoupon discountCoupon)
        {
            throw new NotImplementedException();
        }

        public IResult deleteDiscountCouponById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<DiscountCoupon>> getAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<DiscountCoupon>> getAllByCategoryId(int catId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<DiscountCoupon> getOneById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult updateDiscountCoupon(DiscountCoupon discountCoupon)
        {
            throw new NotImplementedException();
        }
    }
}
