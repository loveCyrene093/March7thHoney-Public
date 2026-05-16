using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Internationalization;
using March7thHoney.Util;

namespace March7thHoney.Command.Command.Cmd;

[CommandInfo("help", "Game.Command.Help.Desc", "Game.Command.Help.Usage", new string[] { "h" }, "", "")]
public class CommandHelp : ICommand
{
	[CommandDefault]
	public async ValueTask Help(CommandArg arg)
	{
		Dictionary<string, CommandInfoAttribute> commands = CommandManager.Instance?.CommandInfo;
		if (arg.Args.Count == 1)
		{
			string key = arg.Args[0];
			if (commands == null || !commands.TryGetValue(key, out CommandInfoAttribute value))
			{
				await arg.SendMsg(I18NManager.Translate("Game.Command.Help.CommandNotFound"));
				return;
			}
			string text = $"/{value.Name} - {I18NManager.Translate(value.Description)}\n\n{I18NManager.Translate(value.Usage)}";
			if (value.Alias.Length != 0)
			{
				text = text + "\n\n" + I18NManager.Translate("Game.Command.Help.CommandAlias") + " " + value.Alias.ToList().ToArrayString();
			}
			if (value.Permission != "")
			{
				text = text + "\n\n" + I18NManager.Translate("Game.Command.Help.CommandPermission") + " " + value.Permission;
			}
			await arg.SendMsg(text);
			return;
		}
		await arg.SendMsg(I18NManager.Translate("Game.Command.Help.Commands"));
		if (commands == null)
		{
			return;
		}
		foreach (CommandInfoAttribute value2 in commands.Values)
		{
			string text2 = $"/{value2.Name} - {I18NManager.Translate(value2.Description)}\n\n{I18NManager.Translate(value2.Usage)}";
			if (value2.Alias.Length != 0)
			{
				text2 = text2 + "\n\n" + I18NManager.Translate("Game.Command.Help.CommandAlias") + " " + value2.Alias.ToList().ToArrayString();
			}
			if (value2.Permission != "")
			{
				text2 = text2 + "\n\n" + I18NManager.Translate("Game.Command.Help.CommandPermission") + " " + value2.Permission;
			}
			await arg.SendMsg(text2);
		}
	}
}
