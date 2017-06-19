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
			var source = new SimpleStringProvider();
			builder.Register(c => source).As<IDataProvider>();
			builder.Register(c => source).As<IContentWriter>();
			builder.RegisterType<ValuesController>();
			var container = builder.Build();
			DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
		}
	}
}