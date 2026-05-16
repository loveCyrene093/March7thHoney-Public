using System.Threading.Tasks;
using March7thHoney.Internationalization;

namespace March7thHoney.Command.Command.Cmd;

[CommandInfo("mail", "Game.Command.Mail.Desc", "Game.Command.Mail.Usage", "", "egglink.manage")]
public class CommandMail : ICommand
{
	[CommandDefault]
	public async ValueTask Mail(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		if (arg.Args.Count < 7)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		if (!arg.Args.Contains("_TITLE") || !arg.Args.Contains("_CONTENT"))
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		string sender = arg.Args[0];
		int templateId = int.Parse(arg.Args[1]);
		int expiredDay = int.Parse(arg.Args[2]);
		string text = "";
		string text2 = "";
		bool flag = false;
		bool flag2 = false;
		foreach (string arg2 in arg.Args)
		{
			if (!(arg2 == "_TITLE"))
			{
				if (arg2 == "_CONTENT")
				{
					flag2 = true;
					continue;
				}
				if (flag && !flag2)
				{
					text = text + arg2 + " ";
				}
				if (flag && flag2)
				{
					text2 = text2 + arg2 + " ";
				}
			}
			else
			{
				flag = true;
			}
		}
		string text3 = text2;
		text2 = text3.Substring(0, text3.Length - 1);
		text3 = text;
		text = text3.Substring(0, text3.Length - 1);
		await arg.Target.Player.MailManager.SendMail(sender, text, text2, templateId, expiredDay);
		await arg.SendMsg(I18NManager.Translate("Game.Command.Mail.MailSent"));
	}
}
