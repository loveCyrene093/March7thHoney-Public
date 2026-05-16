using System.Threading.Tasks;
using March7thHoney.Data.Config;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Inventory;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Player;

namespace March7thHoney.GameServer.Game.Mission.FinishType.Handler;

[MissionFinishType(MissionFinishTypeEnum.ItemNum)]
public class MissionHandlerItemNum : MissionFinishTypeHandler
{
	public override async ValueTask HandleMissionFinishType(PlayerInstance player, SubMissionInfo info, object? arg)
	{
		int num = 0;
		ItemData itemData = player.InventoryManager?.GetItem(info.ParamInt1);
		if (itemData != null)
		{
			num += itemData.Count;
		}
		if (num == info.Progress)
		{
			await player.MissionManager.FinishSubMission(info.ID);
			return;
		}
		MissionManager? missionManager = player.MissionManager;
		if (missionManager == null || missionManager.GetMissionProgress(info.ID) != num)
		{
			await player.MissionManager.SetMissionProgress(info.ID, num);
		}
	}

	public override async ValueTask HandleQuestFinishType(PlayerInstance player, QuestDataExcel quest, FinishWayExcel excel, object? arg)
	{
		int num = 0;
		ItemData itemData = player.InventoryManager?.GetItem(excel.ParamInt1);
		if (itemData != null)
		{
			num += itemData.Count;
		}
		await player.QuestManager.UpdateQuestProgress(quest.QuestID, num);
	}
}
