using Microsoft.Practices.Unity;
using Service.Resolver;
using Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Service.App_Start
{
    public class IocConfigurator
    {
        public static void ConfigureIocUnityContainer()
        {
            UnityContainer container = new UnityContainer();

            registerServices(container);

            DependencyResolver.SetResolver(new DemoUnitDependecyResolver(container));
        }
        private static void registerServices(IUnityContainer container)
        {
            container.RegisterType<IProductRepository, ProductService>();
        }
    }
}