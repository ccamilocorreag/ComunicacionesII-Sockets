using Controlador.Implementaciones;
using Controlador.Interfaces;
using Microsoft.Practices.Unity;
using Modelo.Implementaciones;
using Modelo.Interfaces;
using System.Web.Http;
using Unity.WebApi;

namespace Api.App_Start
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            UnityContainer container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IUsuarioServicio, UsuarioServicio>();
            container.RegisterType<IUsuarioDao, UsuarioDao>();
            container.RegisterType<IPartidaServicio, PartidaServicio>();
            container.RegisterType<IPartidaDao, PartidaDao>();
            container.RegisterType<ICuestionarioServicio, CuestionarioServicio>();
            container.RegisterType<ICuestionarioDao, CuestionarioDao>();
            container.RegisterType<IContextoFactory, ContextoFactory>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}