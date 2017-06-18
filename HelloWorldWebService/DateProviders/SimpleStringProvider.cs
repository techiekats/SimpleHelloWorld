namespace HelloWorldWebService.DateProviders
{
	public class SimpleStringProvider : IDataProvider
	{
		public string GetHelloWorldText(int id)
		{
			return "Hello World";
		}
	}
}