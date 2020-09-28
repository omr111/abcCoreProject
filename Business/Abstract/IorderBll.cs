using Core.DataResult.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IorderBll
    {
        IDataResult<List<order>> getAll();     
        IDataResult<List<order>> getAllCategoryOfTheCustomerByCustomerId(int CustomerId);       
        IDataResult<order> getOneById(int id);
        IResult addOrder(order order);
        IResult updateOrder(order order);
        IResult deleteOrderById(int id);
        IResult deleteOrderByEntity(order order);
    }
}
