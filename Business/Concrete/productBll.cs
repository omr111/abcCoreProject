using Business.Abstract;
using Core.DataResult.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;


namespace Business.Concrete
{
    public class productBll : IproductBll
    {
        public IResult addProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public IResult deleteProductByEntity(Product product)
        {
            throw new NotImplementedException();
        }

        public IResult deleteProductById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Product>> getAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Product>> getAllByCategoryId(int catId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Product> getOneById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult updateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
