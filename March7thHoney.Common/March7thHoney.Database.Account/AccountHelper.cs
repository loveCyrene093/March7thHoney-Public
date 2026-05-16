using System;
using System.Collections.Generic;
using March7thHoney.Util;

namespace March7thHoney.Database.Account;

public static class AccountHelper
{
	public static void CreateAccount(string username, int uid)
	{
		if (AccountData.GetAccountByUserName(username) != null)
		{
			throw new Exception("Account already exists");
		}
		AccountData.GetAccountByUid(uid);
		int i = uid;
		if (uid == 0)
		{
			for (i = 10001; AccountData.GetAccountByUid(i) != null; i++)
			{
			}
		}
		HashSet<string> defaultPermissions = ConfigManager.Config.ServerOption.DefaultPermissions;
		string permissions = string.Join(",", defaultPermissions);
		DatabaseHelper.SaveInstance(new AccountData
		{
			Uid = i,
			Username = username,
			Permissions = permissions
		});
	}
}
