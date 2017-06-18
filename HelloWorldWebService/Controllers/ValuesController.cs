using HelloWorldWebService.DateProviders;
using System.Web.Mvc;

namespace HelloWorldWebService.Controllers
{
	//[RoutePrefix("api/values")]
	public class ValuesController : Controller
    {
		private IDataProvider dataprovider;
		public ValuesController (IDataProvider injectedDataProvider)
		{
			dataprovider = injectedDataProvider;
		}
        // GET: Values
        public ActionResult Index()
        {
            return View();
        }
		//[Route("gethelloworldtext")]
		[HttpGet]
		public string GetHelloWorldText  (int id)
		{
			return dataprovider.GetHelloWorldText(id);
		}
    }
}