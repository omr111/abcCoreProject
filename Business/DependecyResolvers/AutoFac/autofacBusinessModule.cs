using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors.Autofac;
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
            builder.RegisterType<userBll>().As<IuserBll>();
            builder.RegisterType<userDal>().As<IuserDal>();

            builder.RegisterType<CategoryBll>().As<ICategoryBll>();
            builder.RegisterType<CategoryDal>().As<ICategoryDal>();

            builder.RegisterType<DiscountCouponBll>().As<IDiscountCouponBll>();
            builder.RegisterType<DiscountCouponDal>().As<IDiscountCouponDal>();

            builder.RegisterType<orderBll>().As<IorderBll>();
            builder.RegisterType<orderDal>().As<IorderDal>();

            builder.RegisterType<productBll>().As<IproductBll>();
            builder.RegisterType<productDal>().As<IproductDal>();

            builder.RegisterType<productPictureBll>().As<IproductPictureBll>();
            builder.RegisterType<IproductPictureDal>().As<IproductPictureDal>();

            builder.RegisterType<roleBll>().As<IroleBll>();
            builder.RegisterType<roleDal>().As<IroleDal>();

            builder.RegisterType<supplierBll>().As<IsupplierBll>();
            builder.RegisterType<supplierDal>().As<IsupplierDal>();

            builder.RegisterType<AuthBll>().As<IAuthBll>();
            
            builder.RegisterType<jwtHelper>().As<ITokenHelper>();
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions() {
                    Selector=new AspectInterceptorSelector()
                
                }).SingleInstance();

        }
    }
}
