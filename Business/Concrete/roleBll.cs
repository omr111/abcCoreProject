using Business.Abstract;
using Core.DataResult.Abstract;
using Core.DataResult.Concrete;
using DataAccess.Repository.EFRepository.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class roleBll : IroleBll
    {
        IroleDal _role;
        IuserDal _user;
        public roleBll(IroleDal role, IuserDal user)
        {
            _role=role;
            _user = user;
        }
        public IResult addProduct(role role)
        {
            throw new NotImplementedException();
        }
        public IResult addRoleToUser(int roleId, int userId)
        {
            var isExistUser = _user.getOne(x => x.Id == userId);
            if (isExistUser==null)
            {
                return new ErrorResult();
            }
            var isExistRole = _role.getOne(x => x.Id == roleId);
            if (isExistRole==null)
            {
                return new ErrorResult();
            }
            var isExistRoleToUser = _role.getOne(x => x.userRoles.Any(y => y.roleId == roleId && y.userId == userId));
            if (isExistRoleToUser!=null)
            {
                return new ErrorResult();
            }
            _role.addRoleToUser(roleId, userId);
            return new SuccessResult();
        }


        public IResult deleteProductByEntity(role role)
        {
            throw new NotImplementedException();
        }

        public IResult deleteProductById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<role>> getAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<role>> getAllByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<role> getOneById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<role> getOneByName(string roleName)
        {
            throw new NotImplementedException();
        }

        public IResult updateProduct(role role)
        {
            throw new NotImplementedException();
        }
    }
}
