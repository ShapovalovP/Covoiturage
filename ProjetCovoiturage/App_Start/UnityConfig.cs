using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using ProjetCovoiturage.Controllers;
using ProjetCovoiturage.Models;
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
               container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>();
         
            //container.RegisterType<RolesAdminController>(new InjectionConstructor());
            container.RegisterType<ManageController>(new InjectionConstructor());
            //container.RegisterType<UsersAdminController>(new InjectionConstructor());
            container.RegisterType<IServiceTrajet, ServiceTrajet>();
        }
    }
}