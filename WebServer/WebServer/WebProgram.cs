using System.Net;
using March7thHoney.Util;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace March7thHoney.WebServer;

public class WebProgram
{
	public static void Main(string[] args, int port, string address)
	{
		BuildWebHost(args, port, address).Start();
	}

	public static IHost BuildWebHost(string[] args, int port, string address)
	{
		return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(delegate(IWebHostBuilder webBuilder)
		{
			webBuilder.UseStartup<Startup>().ConfigureLogging(delegate(WebHostBuilderContext hostingContext, ILoggingBuilder logging)
			{
				logging.ClearProviders();
			}).UseUrls(address);
			if (ConfigManager.Config.HttpServer.UseSSL)
			{
				webBuilder.UseKestrel(delegate(KestrelServerOptions options)
				{
					options.Listen(IPAddress.Any, port, delegate(ListenOptions listenOptions)
					{
						listenOptions.UseHttps(ConfigManager.Config.KeyStore.KeyStorePath, ConfigManager.Config.KeyStore.KeyStorePassword);
					});
				});
			}
		}).Build();
	}
}
