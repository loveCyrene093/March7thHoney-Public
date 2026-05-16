using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Database.Inventory;
using March7thHoney.Internationalization;

namespace March7thHoney.Command.Command.Cmd;

[CommandInfo("clear", "Game.Command.Clear.Desc", "Game.Command.Clear.Usage", "", "")]
public class CommandClear : ICommand
{
	[CommandMethod("equipment")]
	public async ValueTask ClearEquipment(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		List<ItemData> removeList = arg.Target.Player.InventoryManager.Data.EquipmentItems.Where((ItemData x) => x.EquipAvatar == 0).ToList();
		await arg.Target.Player.InventoryManager.RemoveItems(removeList.Select((ItemData x) => (ItemId: x.ItemId, Count: x.Count, UniqueId: x.UniqueId)).ToList());
		await arg.SendMsg(I18NManager.Translate("Game.Command.Clear.ClearEquipment", removeList.Count.ToString()));
	}

	[CommandMethod("relic")]
	public async ValueTask ClearRelic(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		List<ItemData> removeList = arg.Target.Player.InventoryManager.Data.RelicItems.Where((ItemData x) => x.EquipAvatar == 0).ToList();
		await arg.Target.Player.InventoryManager.RemoveItems(removeList.Select((ItemData x) => (ItemId: x.ItemId, Count: x.Count, UniqueId: x.UniqueId)).ToList());
		await arg.SendMsg(I18NManager.Translate("Game.Command.Clear.ClearRelic", removeList.Count.ToString()));
	}
}
