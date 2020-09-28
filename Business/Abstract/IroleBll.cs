using Core.DataResult.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IroleBll
    {
        IDataResult<List<role>> getAll();
        IDataResult<List<role>> getAllByUserId(int userId);
        IDataResult<role> getOneById(int id);
        IDataResult<role> getOneByName(string roleName);
        IResult addProduct(role role);
        IResult updateProduct(role role);
        IResult deleteProductById(int id);
        IResult deleteProductByEntity(role role);
        IResult addRoleToUser(int roleId, int userId);
    }
}
