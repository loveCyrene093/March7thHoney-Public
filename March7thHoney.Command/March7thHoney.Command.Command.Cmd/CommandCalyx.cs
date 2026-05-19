using System;
using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Calyx;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Internationalization;

namespace March7thHoney.Command.Command.Cmd;

[CommandInfo("calyx", "Game.Command.Calyx.Desc", "Game.Command.Calyx.Usage", "", "")]
public class CommandCalyx : ICommand
{
	[CommandDefault]
	public async ValueTask Default(CommandArg arg)
	{
		PlayerInstance playerInstance = arg.Target?.Player;
		if (playerInstance == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		string[] array = arg.Raw.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
		if (array.Length == 0)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Calyx.Usage"));
			return;
		}
		string text = array[0].ToLowerInvariant();
		if (text == "off")
		{
			playerInstance.CalyxOverrideManager.Disable();
			await arg.SendMsg(I18NManager.Translate("Game.Command.Calyx.ToggleOff"));
		}
		else if (text == "on")
		{
			CalyxOverrideManager calyxOverrideManager = playerInstance.CalyxOverrideManager;
			if (calyxOverrideManager.Data.CachedJson?.BattleConfig == null)
			{
				await arg.SendMsg(I18NManager.Translate("Game.Command.Calyx.NoCachedData"));
				return;
			}
			calyxOverrideManager.Enable();
			await arg.SendMsg(I18NManager.Translate("Game.Command.Calyx.ToggleOn"));
		}
		else
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Calyx.InvalidMode", text));
		}
	}
}
