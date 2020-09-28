using Autofac;
using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Security.Jwt;
using DataAccess.Repository.EFRepository.Abstract;
using DataAccess.Repository.EFRepository.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependecyResolvers.AutoFac
{
   public class autofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<IuserBll>().As<userBll>();
            builder.RegisterType<IuserDal>().As<userDal>();

            builder.RegisterType<ICategoryBll>().As<CategoryBll>();
            builder.RegisterType<ICategoryDal>().As<CategoryDal>();

            builder.RegisterType<IDiscountCouponBll>().As<DiscountCouponBll>();
            builder.RegisterType<IDiscountCouponDal>().As<DiscountCouponDal>();

            builder.RegisterType<IorderBll>().As<orderBll>();
            builder.RegisterType<IorderDal>().As<orderDal>();

            builder.RegisterType<IproductBll>().As<productBll>();
            builder.RegisterType<IproductDal>().As<productDal>();

            builder.RegisterType<IproductPictureBll>().As<productPictureBll>();
            builder.RegisterType<IproductPictureDal>().As<productPictureDal>();

            builder.RegisterType<IroleBll>().As<roleBll>();
            builder.RegisterType<IroleDal>().As<roleDal>();

            builder.RegisterType<IsupplierBll>().As<supplierBll>();
            builder.RegisterType<IsupplierDal>().As<supplierDal>();

            builder.RegisterType<ITokenHelper>().As<jwtHelper>();

        }
    }
}
