using System;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Internationalization;

namespace March7thHoney.Command.Command.Cmd;

[CommandInfo("give", "Game.Command.Give.Desc", "Game.Command.Give.Usage", new string[] { "g" }, "", "")]
public class CommandGive : ICommand
{
	[CommandDefault]
	public async ValueTask GiveItem(CommandArg arg)
	{
		PlayerInstance player = arg.Target?.Player;
		if (player == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		if (arg.BasicArgs.Count == 0)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		GameData.ItemConfigData.TryGetValue(arg.GetInt(0), out ItemConfigExcel itemData);
		if (itemData == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Give.ItemNotFound"));
			return;
		}
		arg.CharacterArgs.TryGetValue("x", out string value);
		arg.CharacterArgs.TryGetValue("l", out string value2);
		arg.CharacterArgs.TryGetValue("r", out string value3);
		if (value == null)
		{
			value = "1";
		}
		if (value2 == null)
		{
			value2 = "1";
		}
		if (value3 == null)
		{
			value3 = "1";
		}
		if (!int.TryParse(value, out var amount) || !int.TryParse(value2, out var result) || !int.TryParse(value3, out var result2))
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		await player.InventoryManager.AddItem(arg.GetInt(0), amount, notify: true, Math.Min(result2, 5), Math.Max(Math.Min(result, 80), 1));
		await arg.SendMsg(I18NManager.Translate("Game.Command.Give.GiveItem", player.Uid.ToString(), amount.ToString(), itemData.Name ?? itemData.ID.ToString()));
	}
}
