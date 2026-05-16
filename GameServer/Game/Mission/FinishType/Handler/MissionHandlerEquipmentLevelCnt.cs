using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.Data.Config;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Inventory;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Player;

namespace March7thHoney.GameServer.Game.Mission.FinishType.Handler;

[MissionFinishType(MissionFinishTypeEnum.EquipmentLevelCnt)]
public class MissionHandlerEquipmentLevelCnt : MissionFinishTypeHandler
{
	public override async ValueTask HandleMissionFinishType(PlayerInstance player, SubMissionInfo info, object? arg)
	{
		await ValueTask.CompletedTask;
	}

	public override async ValueTask HandleQuestFinishType(PlayerInstance player, QuestDataExcel quest, FinishWayExcel excel, object? arg)
	{
		int num = 0;
		foreach (ItemData item in player.InventoryManager?.Data.EquipmentItems ?? new List<ItemData>())
		{
			if (item.Level >= excel.ParamInt1)
			{
				num++;
			}
		}
		await player.QuestManager.UpdateQuestProgress(quest.QuestID, num);
	}
}
