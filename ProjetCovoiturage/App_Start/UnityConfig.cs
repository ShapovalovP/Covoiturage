using ProjetCovoiturage.Controllers;
using ProjetCovoiturage.Services;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.Mvc5;

namespace ProjetCovoiturage
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            container.RegisterType<AccountController>(new InjectionConstructor());

            container.RegisterType<IServiceTrajet, ServiceTrajet>();
        }
    }
}