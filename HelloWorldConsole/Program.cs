using System;
using System.Configuration;
using System.Net.Http;
namespace HelloWorldConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			string apiEndpoint = ConfigurationManager.AppSettings["helloworldservice-endpoint"];
			GetHelloWorldText(apiEndpoint);
			Console.WriteLine($"Waiting for response from {apiEndpoint}....");
			Console.ReadKey();
		}
		private static async void GetHelloWorldText (string apiEndpoint)
		{
			HttpClient client = new HttpClient();
			try
			{
				var responseText = await client.GetStringAsync(apiEndpoint);
				Console.WriteLine(responseText);
			}

			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
