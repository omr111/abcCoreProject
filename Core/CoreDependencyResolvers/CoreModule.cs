using Core.Utilities.Ioc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CoreDependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void load(IServiceCollection services)
        {
            services.AddMemoryCache();
        }
    }
}
