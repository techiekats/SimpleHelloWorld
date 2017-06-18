using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorldWebService.Controllers
{
	//[RoutePrefix("api/values")]
	public class ValuesController : Controller
    {
        // GET: Values
        public ActionResult Index()
        {
            return View();
        }
		//[Route("gethelloworldtext")]
		[HttpGet]
		public string GetHelloWorldText  (int id)
		{
			return "Hello World";
		}
    }
}