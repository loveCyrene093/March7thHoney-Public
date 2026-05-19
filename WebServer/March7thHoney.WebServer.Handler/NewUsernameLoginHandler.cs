using System;
using March7thHoney.Database.Account;
using March7thHoney.Util;
using March7thHoney.WebServer.Objects;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace March7thHoney.WebServer.Handler;

public class NewUsernameLoginHandler
{
	private sealed record LoginSession(string Uid, string Username, string Email, string DispatchToken);

	public JsonResult Handle(string account, string password)
	{
		LoginSession loginSession = ResolveSession(account);
		if (loginSession == null)
		{
			return new JsonResult(new NewLoginResJson
			{
				message = "Account not found",
				retcode = -201
			});
		}
		NewLoginResJson newLoginResJson = new NewLoginResJson();
		newLoginResJson.message = "OK";
		newLoginResJson.data = new NewLoginResJson.VerifyData(loginSession.Uid, loginSession.Email, loginSession.DispatchToken);
		newLoginResJson.data.user_info.account_name = loginSession.Username;
		newLoginResJson.data.user_info.area_code = "**";
		newLoginResJson.data.user_info.country = "US";
		newLoginResJson.data.user_info.is_email_verify = "1";
		return new JsonResult(newLoginResJson);
	}

	public ContentResult HandleLegacy(string account, string password)
	{
		LoginSession loginSession = ResolveSession(account);
		if (loginSession == null)
		{
			return new ContentResult
			{
				ContentType = "application/json",
				Content = "{\"retcode\":-201,\"message\":\"Account not found\"}"
			};
		}
		var value = new
		{
			retcode = 0,
			message = "OK",
			data = new
			{
				user_info = new
				{
					aid = loginSession.Uid,
					mid = loginSession.Uid,
					account_name = loginSession.Username,
					email = loginSession.Email,
					is_email_verify = 0,
					area_code = "**",
					mobile = "",
					safe_area_code = "",
					safe_mobile = "",
					realname = "",
					identity_code = "",
					rebind_area_code = "",
					rebind_mobile = "",
					rebind_mobile_time = "1",
					links = Array.Empty<object>(),
					country = "CN",
					password_time = "1",
					is_adult = 0,
					unmasked_email = "",
					unmasked_email_type = 0
				},
				token = new
				{
					token_type = 1,
					token = loginSession.DispatchToken
				},
				ext_user_info = new
				{
					guardian_email = "",
					birth = "0"
				}
			}
		};
		return new ContentResult
		{
			ContentType = "application/json",
			Content = JsonConvert.SerializeObject(value)
		};
	}

	private static LoginSession? ResolveSession(string account)
	{
		AccountData accountByUserName = AccountData.GetAccountByUserName(account);
		if (accountByUserName == null)
		{
			if (!ConfigManager.Config.ServerOption.AutoCreateUser)
			{
				return null;
			}
			AccountHelper.CreateAccount(account, 0);
			accountByUserName = AccountData.GetAccountByUserName(account);
			if (accountByUserName == null)
			{
				return null;
			}
		}
		AccountData accountData = AccountData.GetAccountByUid(accountByUserName.Uid) ?? accountByUserName;
		string text = accountData.Username ?? account;
		return new LoginSession(accountData.Uid.ToString(), text, text + "@StarRail.com", accountData.GenerateDispatchToken());
	}
}
