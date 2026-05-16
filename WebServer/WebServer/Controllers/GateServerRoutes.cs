using System.Threading.Tasks;
using March7thHoney.Util;
using March7thHoney.WebServer.Handler;
using March7thHoney.WebServer.Request;
using Microsoft.AspNetCore.Mvc;

namespace March7thHoney.WebServer.Controllers;

[ApiController]
[Route("/")]
public class GateServerRoutes
{
	[HttpGet("/query_gateway")]
	public async ValueTask<ContentResult> QueryGateway([FromQuery] GateWayRequest req)
	{
		if (!ConfigManager.Config.ServerOption.ServerConfig.RunGateway)
		{
			return new ContentResult
			{
				StatusCode = 404
			};
		}
		await ValueTask.CompletedTask;
		QueryGatewayHandler queryGatewayHandler = new QueryGatewayHandler(req);
		return new ContentResult
		{
			Content = queryGatewayHandler.Data,
			StatusCode = 200,
			ContentType = "text/plain"
		};
	}
}
