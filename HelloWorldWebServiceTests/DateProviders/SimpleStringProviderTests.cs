using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldWebService.DateProviders;

namespace HelloWorldWebService.DateProviders.Tests
{
	[TestClass()]
	public class SimpleStringProviderTests
	{
		[TestMethod()]
		public void WriteTest()
		{
			var source = new SimpleStringProvider();
			var initial = source.GetHelloWorldText(10);
			string newText = "Hello, new world !";
			source.Write(newText);
			Assert.AreEqual("Hello World", initial);
			Assert.AreEqual(newText, source.GetHelloWorldText(10));
		}
	}
}