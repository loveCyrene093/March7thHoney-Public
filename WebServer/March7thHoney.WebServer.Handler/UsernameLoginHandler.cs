using March7thHoney.Database.Account;
using March7thHoney.Util;
using March7thHoney.WebServer.Objects;
using Microsoft.AspNetCore.Mvc;

namespace March7thHoney.WebServer.Handler;

public class UsernameLoginHandler
{
	public JsonResult Handle(string account, string password, bool isCrypto)
	{
		LoginResJson loginResJson = new LoginResJson();
		AccountData accountByUserName = AccountData.GetAccountByUserName(account);
		if (accountByUserName == null)
		{
			if (!ConfigManager.Config.ServerOption.AutoCreateUser)
			{
				return new JsonResult(new LoginResJson
				{
					message = "Account not found",
					retcode = -201
				});
			}
			AccountHelper.CreateAccount(account, 0);
			accountByUserName = AccountData.GetAccountByUserName(account);
		}
		if (accountByUserName != null)
		{
			AccountData accountData = AccountData.GetAccountByUid(accountByUserName.Uid) ?? accountByUserName;
			string text = accountData.Username ?? account;
			loginResJson.message = "OK";
			loginResJson.data = new LoginResJson.VerifyData(accountData.Uid.ToString(), text + "@StarRail.com", accountData.GenerateDispatchToken());
			loginResJson.data.account.name = text;
			loginResJson.data.account.is_email_verify = "1";
		}
		return new JsonResult(loginResJson);
	}
}
