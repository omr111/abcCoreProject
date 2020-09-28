using Core.DataResult.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IsupplierBll
    {
        IDataResult<List<supplier>> getAll();
       
        IDataResult<List<supplier>> getAllSupplierOfTheProductByProductId(int productId);
        IDataResult<supplier> getOneById(int id);
        IResult addSupplier(supplier supplier);
        IResult updateSupplier(supplier supplier);
        IResult deleteSupplierById(int id);
        IResult deleteSupplierByEntity(supplier supplier);
    }
}
