using Business.Abstract;
using Business.Constants.BllMethodMessages;
using Core.DataResult.Abstract;
using Core.DataResult.Concrete;
using DataAccess.Repository.EFRepository.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CategoryBll : ICategoryBll
    {
        ICategoryDal _categoryDal;
        public CategoryBll(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public IResult addCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public IResult deleteCategoryByEntity(Category category)
        {
            throw new NotImplementedException();
        }

        public IResult deleteCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Category>> getAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Category>> getAllByCategoryId(int catId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Category>> getAllCategoryOfTheProductsByProductId(int productId)
        {
            return new DataSuccessResult<List<Category>>(_categoryDal.getAll(x => x.Products.Any
            (y => y.categoryId == x.Id)).ToList(), bllMessages.categoriesListed);
        }

        public IDataResult<Category> getOneById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult updateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
