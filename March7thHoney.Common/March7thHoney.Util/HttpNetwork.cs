using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace March7thHoney.Util;

public static class HttpNetwork
{
	public static async ValueTask<(int, string?)> SendGetRequest(string url, int timeout = 30)
	{
		_ = 1;
		try
		{
			using HttpClient client = new HttpClient();
			client.Timeout = TimeSpan.FromSeconds(timeout);
			HttpResponseMessage response = await client.GetAsync(url);
			string item = await response.Content.ReadAsStringAsync();
			return ((int)response.StatusCode, item);
		}
		catch (Exception ex)
		{
			return (500, ex.Message);
		}
	}
}
