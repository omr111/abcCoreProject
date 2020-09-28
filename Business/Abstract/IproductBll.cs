using Core.DataResult.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;


namespace Business.Abstract
{
    public interface   IproductBll
    {
        IDataResult<List<Product>> getAll();
        IDataResult<List<Product>> getAllByCategoryId(int catId);
        IDataResult<Product> getOneById(int id);
        IResult addProduct(Product product);
        IResult updateProduct(Product product);
        IResult deleteProductById(int id);
        IResult deleteProductByEntity(Product product);
    }
}
