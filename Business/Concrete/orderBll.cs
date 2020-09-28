using Business.Abstract;
using Core.DataResult.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class orderBll : IorderBll
    {
        public IResult addOrder(order order)
        {
            throw new NotImplementedException();
        }

        public IResult deleteOrderByEntity(order order)
        {
            throw new NotImplementedException();
        }

        public IResult deleteOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<order>> getAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<order>> getAllCategoryOfTheCustomerByCustomerId(int CustomerId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<order> getOneById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult updateOrder(order order)
        {
            throw new NotImplementedException();
        }
    }
}
