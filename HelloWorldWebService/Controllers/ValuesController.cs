using HelloWorldWebService.DateProviders;
using System.Web.Mvc;

namespace HelloWorldWebService.Controllers
{
	public class ValuesController : Controller
    {
		private IDataProvider dataprovider;
		private IContentWriter contentWriter;
		public ValuesController (IDataProvider injectedDataProvider, IContentWriter injectedContentWriter)
		{
			dataprovider = injectedDataProvider;
			contentWriter = injectedContentWriter;
		}
        // GET: Values
        public ActionResult Index()
        {
            return View();
        }
		[HttpGet]
		public string GetHelloWorldText  (int id)
		{
			return dataprovider.GetHelloWorldText(id);
		}
		[HttpPost]
		public void UpdateHelloWorldText (string s)
		{
			contentWriter.Write(s);
		}
    }
}