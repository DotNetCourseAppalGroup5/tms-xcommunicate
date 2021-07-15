using Models.Entities;
using Repositories.IGenericRepository;
using Repositories.Repositories;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace WebApp
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IGenericRepository<Group>, GroupRepository>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}