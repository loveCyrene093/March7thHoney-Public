using System;
using March7thHoney.Database.Account;
using Microsoft.AspNetCore.Mvc;

namespace March7thHoney.WebServer.Handler;

public class NewTokenLoginHandler
{
	public ContentResult Handle(string mid, string token)
	{
		if (!int.TryParse(mid, out var result))
		{
			return new ContentResult
			{
				ContentType = "application/json",
				Content = "{\"retcode\":-201,\"message\":\"Account not found\"}"
			};
		}
		AccountData accountByUid = AccountData.GetAccountByUid(result);
		if (accountByUid == null || !string.Equals(accountByUid.DispatchToken, token, StringComparison.Ordinal))
		{
			return new ContentResult
			{
				ContentType = "application/json",
				Content = "{\"retcode\":-201,\"message\":\"Account not found\"}"
			};
		}
		string value = accountByUid.Uid.ToString();
		string value2 = accountByUid.Username + "@StarRail.com";
		string content = $"{{\"retcode\":0,\"message\":\"OK\",\"data\":{{\"user_info\":{{\"aid\":\"{value}\",\"mid\":\"{value}\",\"account_name\":\"{accountByUid.Username}\",\"email\":\"{value2}\",\"is_email_verify\":0,\"area_code\":\"**\",\"mobile\":\"\",\"safe_area_code\":\"\",\"safe_mobile\":\"\",\"realname\":\"\",\"identity_code\":\"\",\"rebind_area_code\":\"\",\"rebind_mobile\":\"\",\"rebind_mobile_time\":\"1\",\"links\":[],\"country\":\"CN\",\"password_time\":\"1\",\"is_adult\":0,\"unmasked_email\":\"\",\"unmasked_email_type\":0}},\"token\":{{\"token_type\":1,\"token\":\"{token}\"}},\"ext_user_info\":{{\"guardian_email\":\"\",\"birth\":\"0\"}}}}}}";
		return new ContentResult
		{
			ContentType = "application/json",
			Content = content
		};
	}
}
