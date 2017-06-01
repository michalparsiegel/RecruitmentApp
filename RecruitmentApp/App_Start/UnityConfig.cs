using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using RecruitmentApp.Service;
using RecruitmentApp.Controllers;

namespace RecruitmentApp
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<ICustomerService, CustomerService>();         
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}