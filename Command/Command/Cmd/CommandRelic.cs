using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Internationalization;

namespace March7thHoney.Command.Command.Cmd;

[CommandInfo("relic", "Game.Command.Relic.Desc", "Game.Command.Relic.Usage", "", "")]
public class CommandRelic : ICommand
{
	[CommandDefault]
	public async ValueTask GiveRelic(CommandArg arg)
	{
		PlayerInstance player = arg.Target?.Player;
		if (player == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		if (arg.BasicArgs.Count < 2)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		arg.CharacterArgs.TryGetValue("x", out string value);
		arg.CharacterArgs.TryGetValue("l", out string value2);
		if (value == null)
		{
			value = "1";
		}
		if (value2 == null)
		{
			value2 = "0";
		}
		if (!int.TryParse(value, out var amount) || !int.TryParse(value2, out var level))
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		int num = 1;
		int mainAffixId = 0;
		if (!arg.BasicArgs[1].Contains(':'))
		{
			mainAffixId = int.Parse(arg.BasicArgs[1]);
			num++;
		}
		List<(int, int)> subAffixes = new List<(int, int)>();
		for (int i = num; i < arg.BasicArgs.Count; i++)
		{
			string[] array = arg.BasicArgs[i].Split(':');
			if (array.Length != 2 || !int.TryParse(array[0], out var result) || !int.TryParse(array[1], out var result2))
			{
				await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
				return;
			}
			subAffixes.Add((result, result2));
		}
		for (int j = 0; j < amount; j++)
		{
			switch ((await player.InventoryManager.HandleRelic(int.Parse(arg.BasicArgs[0]), ++player.InventoryManager.Data.NextUniqueId, level, mainAffixId, subAffixes)).Item1)
			{
			case 1:
				await arg.SendMsg(I18NManager.Translate("Game.Command.Relic.RelicNotFound"));
				return;
			case 2:
				await arg.SendMsg(I18NManager.Translate("Game.Command.Relic.InvalidMainAffixId"));
				return;
			case 3:
				await arg.SendMsg(I18NManager.Translate("Game.Command.Relic.InvalidSubAffixId"));
				return;
			}
		}
		await arg.SendMsg(I18NManager.Translate("Game.Command.Relic.RelicGiven", player.Uid.ToString(), amount.ToString(), arg.BasicArgs[0], mainAffixId.ToString()));
	}
}
