using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using March7thHoney.Database.Account;
using March7thHoney.GameServer.Game.Calyx;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server;
using March7thHoney.Internationalization;
using March7thHoney.Kcp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace March7thHoney.WebServer.Controllers;

[ApiController]
[Route("/")]
public class JsonRoutes : ControllerBase
{
	[HttpPost("/sr-tools")]
	public async ValueTask<ContentResult> SrTools()
	{
		_ = 1;
		try
		{
			using StreamReader reader = new StreamReader(base.Request.Body, Encoding.UTF8);
			JToken jToken = JToken.Parse(await reader.ReadToEndAsync());
			string s = jToken["username"]?.ToString() ?? "";
			jToken["password"]?.ToString();
			string text = jToken["data"]?.ToString(Formatting.None) ?? "";
			if (!int.TryParse(s, out var result))
			{
				return new ContentResult
				{
					StatusCode = 400,
					Content = "Username field must be the player's UID (integer).",
					ContentType = "text/plain"
				};
			}
			AccountData accountByUid = AccountData.GetAccountByUid(result);
			if (accountByUid == null)
			{
				return new ContentResult
				{
					StatusCode = 400,
					Content = "uid not found on server",
					ContentType = "text/plain"
				};
			}
			Connection connection = null;
			foreach (March7thHoneyConnection value in March7thHoneyListener.Connections.Values)
			{
				if (value is Connection connection2 && connection2.Player?.Uid == accountByUid.Uid)
				{
					connection = connection2;
					break;
				}
			}
			if (connection?.Player == null)
			{
				return new ContentResult
				{
					StatusCode = 400,
					Content = "player offline",
					ContentType = "text/plain"
				};
			}
			if (text != string.Empty)
			{
				PlayerInstance player = connection.Player;
				await FreesrShared.ImportJson(text, player, async delegate(string[] msg)
				{
					if (msg[0] == "Game.Command.Json.ImportSummary" || msg[0] == "Game.Command.Json.AvatarExcelNotFound")
					{
						return;
					}
					throw new Exception(I18NManager.Translate(msg[0], msg.Skip(1).ToArray()));
				});
			}
			return new ContentResult
			{
				StatusCode = 200,
				Content = "Successfully synced data from website!",
				ContentType = "application/json"
			};
		}
		catch (Exception ex)
		{
			return new ContentResult
			{
				StatusCode = 500,
				Content = ex.Message,
				ContentType = "text/plain"
			};
		}
	}

	[HttpGet("/sr-tools-export")]
	public async ValueTask<EmptyResult> DownloadFreedata()
	{
		int result = 0;
		if (base.Request.Query.ContainsKey("uid"))
		{
			int.TryParse(base.Request.Query["uid"], out result);
		}
		if (result == 0)
		{
			base.Response.StatusCode = 400;
			base.Response.ContentType = "text/plain";
			await base.Response.WriteAsync("Error: Missing valid uid parameter");
			return new EmptyResult();
		}
		string text = await FreesrShared.ExportPlayerDataAsync(result, writeIndented: true);
		base.Response.StatusCode = 200;
		base.Response.ContentType = "application/octet-stream";
		base.Response.Headers["Content-Disposition"] = "attachment; filename=freesr-data.json; filename*=UTF-8''freesr-data.json";
		await base.Response.WriteAsync(text);
		return new EmptyResult();
	}
}
