using DomainCore.Interfaces;
using Infrastructure;
using Services.Implementations;
using Services.Interfaces;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IGenericRepository<DomainCore.Models.Content>, GenericRepository<DomainCore.Models.Content>>();
            container.RegisterType<IGenericRepository<DomainCore.Models.Domain>, GenericRepository<DomainCore.Models.Domain>>();

            container.RegisterType<IDomainService, DomainService>();
            container.RegisterType<IContentService, ContentService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}