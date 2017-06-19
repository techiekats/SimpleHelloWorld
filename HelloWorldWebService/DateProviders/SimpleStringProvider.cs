namespace HelloWorldWebService.DateProviders
{
	public class SimpleStringProvider : IDataProvider, IContentWriter
	{
		private string content = "Hello World";
		public string GetHelloWorldText(int id)
		{
			return content;
		}

		public void Write(string s)
		{
			content = s;
		}
	}
}