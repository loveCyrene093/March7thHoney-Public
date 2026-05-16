using System;
using March7thHoney.Database.Account;
using March7thHoney.WebServer.Objects;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace March7thHoney.WebServer.Handler;

public class ComboTokenGranterHandler
{
	public JsonResult Handle(int app_id, int channel_id, string data, string device, string sign)
	{
		LoginTokenData loginTokenData = JsonConvert.DeserializeObject<LoginTokenData>(data);
		ComboTokenResJson comboTokenResJson = new ComboTokenResJson();
		if (loginTokenData == null)
		{
			comboTokenResJson.retcode = -202;
			comboTokenResJson.message = "Invalid login data";
			return new JsonResult(comboTokenResJson);
		}
		if (!int.TryParse(loginTokenData.uid, out var result))
		{
			comboTokenResJson.retcode = -202;
			comboTokenResJson.message = "Invalid login data";
			return new JsonResult(comboTokenResJson);
		}
		AccountData accountByUid = AccountData.GetAccountByUid(result);
		if (accountByUid == null || !string.Equals(accountByUid.DispatchToken, loginTokenData.token, StringComparison.Ordinal))
		{
			comboTokenResJson.retcode = -201;
			comboTokenResJson.message = "Game account cache information error";
			return new JsonResult(comboTokenResJson);
		}
		comboTokenResJson.message = "OK";
		comboTokenResJson.data = new ComboTokenResJson.LoginData(accountByUid.Uid.ToString(), accountByUid.GenerateComboToken());
		return new JsonResult(comboTokenResJson);
	}
}
