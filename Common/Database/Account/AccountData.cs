using March7thHoney.Util;
using SqlSugar;

namespace March7thHoney.Database.Account;

[SugarTable("Account")]
public class AccountData : BaseDatabaseDataHelper
{
	public string? Username { get; set; }

	[SugarColumn(IsNullable = true)]
	public string? ComboToken { get; set; }

	[SugarColumn(IsNullable = true)]
	public string? DispatchToken { get; set; }

	[SugarColumn(IsNullable = true)]
	public string? Permissions { get; set; }

	public static AccountData? GetAccountByUserName(string username)
	{
		AccountData result = null;
		DatabaseHelper.GetAllInstance<AccountData>()?.ForEach(delegate(AccountData account)
		{
			if (account.Username == username)
			{
				result = account;
			}
		});
		return result;
	}

	public static AccountData? GetAccountByUid(int uid)
	{
		return DatabaseHelper.Instance?.GetInstance<AccountData>(uid);
	}

	public string GenerateDispatchToken()
	{
		DispatchToken = Crypto.CreateSessionKey(base.Uid.ToString());
		return DispatchToken;
	}

	public string GenerateComboToken()
	{
		ComboToken = Crypto.CreateSessionKey(base.Uid.ToString());
		return ComboToken;
	}
}
