using Business.Abstract;
using Business.BusinessAspect;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Performance;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
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
       // [SecuredOperation("Customer")]  //rol yönetimi   
        [CacheAspect()]
        [PerformanceAspect(5)] //ürünlerin getirilme işlemi 5 saniyeden fazla sürerse debug'a yazacak
        [LogAspect(typeof(DatabaseLogger))] //dosyaya loglama yapar
        public IDataResult<List<Product>> getAll()
        {
            return new DataSuccessResult<List<Product>>(_product.getAll());
        }

        [CacheAspect()]
        public IDataResult<List<Product>> getAllByCategoryId(int catId)
        {
            throw new NotImplementedException();
        }
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<Product> getOneById(int id)
        {
            return new DataSuccessResult<Product>(_product.getOne(x => x.Id == id));
        }
        [CacheRemoveAspect("IproductBll.get")]
        public IResult updateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
