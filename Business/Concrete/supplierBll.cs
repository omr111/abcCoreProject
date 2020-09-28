using Business.Abstract;
using Core.DataResult.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class supplierBll : IsupplierBll
    {
        public IResult addSupplier(supplier supplier)
        {
            throw new NotImplementedException();
        }

        public IResult deleteSupplierByEntity(supplier supplier)
        {
            throw new NotImplementedException();
        }

        public IResult deleteSupplierById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<supplier>> getAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<supplier>> getAllSupplierOfTheProductByProductId(int productId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<supplier> getOneById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult updateSupplier(supplier supplier)
        {
            throw new NotImplementedException();
        }
    }
}
