using System;
using System.Threading.Tasks;
using March7thHoney.Database.Account;
using March7thHoney.Internationalization;

namespace March7thHoney.Command.Command.Cmd;

[CommandInfo("account", "Game.Command.Account.Desc", "Game.Command.Account.Usage", "", "egglink.manage")]
public class CommandAccount : ICommand
{
	[CommandMethod("create")]
	public async ValueTask CreateAccount(CommandArg arg)
	{
		if (arg.Args.Count < 2)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		string text = arg.Args[1];
		int result = 0;
		if (arg.Args.Count > 2 && !int.TryParse(arg.Args[2], out result))
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Account.InvalidUid"));
			return;
		}
		if (AccountData.GetAccountByUserName(text) != null)
		{
			await arg.SendMsg(string.Format(I18NManager.Translate("Game.Command.Account.DuplicateAccount"), text));
			return;
		}
		if (result != 0 && AccountData.GetAccountByUid(result) != null)
		{
			await arg.SendMsg(string.Format(I18NManager.Translate("Game.Command.Account.DuplicateUID"), result));
			return;
		}
		try
		{
			AccountHelper.CreateAccount(text, result);
			await arg.SendMsg(I18NManager.Translate("Game.Command.Account.CreateSuccess", text));
		}
		catch (Exception ex)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Account.CreateError", ex.Message));
		}
	}
}
