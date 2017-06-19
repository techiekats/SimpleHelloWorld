using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldWebService.Controllers;
using System;
using HelloWorldWebService.DateProviders;

namespace HelloWorldWebService.Controllers.Tests
{
	[TestClass()]
	public class ValuesControllerTests
	{
	
		[TestMethod()]
		public void GetHelloWorldTextTest()
		{
			var source = new SimpleStringProvider();
			var valuesController = new ValuesController(source, source);
			Assert.AreEqual("Hello World", valuesController.GetHelloWorldText(10));
		}

		[TestMethod()]
		public void UpdateHelloWorldTextTest()
		{
			var source = new SimpleStringProvider();
			var valuesController = new ValuesController(source, source);
			string newText = "Hello beautiful world !";
			valuesController.UpdateHelloWorldText(newText);
			Assert.AreEqual(newText, valuesController.GetHelloWorldText(10));
		}
	}
}