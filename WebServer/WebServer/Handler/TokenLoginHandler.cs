using System;
using March7thHoney.Database.Account;
using March7thHoney.WebServer.Objects;
using Microsoft.AspNetCore.Mvc;

namespace March7thHoney.WebServer.Handler;

public class TokenLoginHandler
{
	public JsonResult Handle(string uid, string token)
	{
		AccountData accountByUid = AccountData.GetAccountByUid(int.Parse(uid));
		LoginResJson loginResJson = new LoginResJson();
		if (accountByUid == null || !string.Equals(accountByUid.DispatchToken, token, StringComparison.Ordinal))
		{
			loginResJson.retcode = -201;
			loginResJson.message = "Game account cache information error";
		}
		else
		{
			string text = accountByUid.Username ?? uid;
			loginResJson.message = "OK";
			loginResJson.data = new LoginResJson.VerifyData(accountByUid.Uid.ToString(), text + "@StarRail.com", token);
			loginResJson.data.account.name = text;
			loginResJson.data.account.is_email_verify = "1";
		}
		return new JsonResult(loginResJson);
	}
}
