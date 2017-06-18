using Autofac;
using Autofac.Integration.Mvc;
using HelloWorldWebService.Controllers;
using HelloWorldWebService.DateProviders;
using System.Web.Mvc;

namespace HelloWorldWebService
{
	public class AutofacConfig
	{
		public static void Initialize ()
		{
			var builder = new ContainerBuilder();
			builder.Register(c => new SimpleStringProvider()).As<IDataProvider>();
			builder.RegisterType<ValuesController>();
			var container = builder.Build();
			DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
		}
	}
}