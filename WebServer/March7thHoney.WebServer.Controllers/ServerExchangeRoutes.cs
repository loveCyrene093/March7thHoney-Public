using System.Threading.Tasks;
using March7thHoney.Database;
using March7thHoney.Database.Account;
using March7thHoney.Util;
using Microsoft.AspNetCore.Mvc;

namespace March7thHoney.WebServer.Controllers;

[ApiController]
[Route("/")]
public class ServerExchangeRoutes
{
	[HttpGet("/get_account_info")]
	public async ValueTask<ContentResult> GetAccountInfo([FromQuery] string accountUid)
	{
		if (!ConfigManager.Config.ServerOption.ServerConfig.RunDispatch)
		{
			return new ContentResult
			{
				StatusCode = 404
			};
		}
		if (string.IsNullOrEmpty(accountUid) || !int.TryParse(accountUid, out var result))
		{
			return new ContentResult
			{
				StatusCode = 400
			};
		}
		AccountData account = DatabaseHelper.Instance?.GetInstance<AccountData>(result);
		if (account == null)
		{
			return new ContentResult
			{
				StatusCode = 404,
				Content = "Account not found"
			};
		}
		await ValueTask.CompletedTask;
		return new ContentResult
		{
			Content = account.Uid.ToString(),
			StatusCode = 200,
			ContentType = "plain/text; charset=utf-8"
		};
	}
}
