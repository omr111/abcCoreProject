using Business.Abstract;
using Business.BusinessAspect;
using Core.Aspects.Autofac.Caching;
using Core.DataResult.Abstract;
using Core.DataResult.Concrete;
using DataAccess.Repository.EFRepository.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;


namespace Business.Concrete
{
    public class productBll : IproductBll
    {
        IproductDal _product;
        public productBll(IproductDal product)
        {
            _product = product;
        }
        
        [CacheRemoveAspect("IproductBll.get")]//product bll'indeki methodlardan get ile başlayan methodların cache'lerini sil demek"
        public IResult addProduct(Product product)
        {
            throw new NotImplementedException();
        }
        [CacheRemoveAspect("IproductBll.get")]
        public IResult deleteProductByEntity(Product product)
        {
            throw new NotImplementedException();
        }
        [CacheRemoveAspect("IproductBll.get")]
        public IResult deleteProductById(int id)
        {
            throw new NotImplementedException();
        }
        [SecuredOperation("Customer")]
     
        [CacheAspect()]
     
        public IDataResult<List<Product>> getAll()
        {
            return new DataSuccessResult<List<Product>>(_product.getAll());
        }

        [CacheAspect()]
        public IDataResult<List<Product>> getAllByCategoryId(int catId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Product> getOneById(int id)
        {
            throw new NotImplementedException();
        }
        [CacheRemoveAspect("IproductBll.get")]
        public IResult updateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
