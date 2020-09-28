using System;
using System.Collections.Generic;
using System.Text;
using Core.dataAccess;
using DataAccess.entities;
using DataAccess.Repository.EFRepository.Abstract;
using Entities.Concrete;
namespace DataAccess.Repository.EFRepository.Concrete
{
    public class  roleDal : RepositoryBase<role, abcContext>, IroleDal
    {
        public void addRoleToUser( int roleId,int userId)
        {
            using (var ctx=new abcContext())
            {
                ctx.userRoles.Add(new userRole { roleId = roleId, userId = userId });
                ctx.SaveChanges();
            }
        }
    }
}
