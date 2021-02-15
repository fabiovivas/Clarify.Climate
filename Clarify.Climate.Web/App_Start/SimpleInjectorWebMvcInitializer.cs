using System.Reflection;
using System.Web.Mvc;
using Clarify.Climate.Business;
using Clarify.Climate.Domain;
using Clarify.Climate.Domain.interfaces.Business;
using Clarify.Climate.Domain.interfaces.Repository;
using Clarify.Climate.Repository.repository;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using SimpleInjector.Lifestyles;

namespace Clarify.Climate.Web.App_Start
{
    public class SimpleInjectorWebMvcInitializer
    {
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            InitializeContainer(container);
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            container.Verify();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
        private static void InitializeContainer(Container container)
        {
            container.Register<IRepository<PrevisaoClima>, RepositoryBase<PrevisaoClima>>();
            container.Register<IRepository<Cidade>, RepositoryBase<Cidade>>();
            container.Register<IBusiness<PrevisaoClima>, BusinessBase<PrevisaoClima>>();
            container.Register<IBusiness<Cidade>, BusinessBase<Cidade>>();
            container.Register<IClimateBusiness, ClimateBusiness>();
        }
    }
}