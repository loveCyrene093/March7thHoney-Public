using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Config.Scene;
using March7thHoney.Data.Excel;
using March7thHoney.GameServer.Game.Activity.Activities;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Game.Scene;
using March7thHoney.GameServer.Game.Scene.Entity;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Activity.Loaders;

public class TrialActivityEntityLoader(SceneInstance scene, PlayerInstance player) : SceneEntityLoader(scene)
{
	public PlayerInstance Player = player;

	public override async ValueTask LoadEntity()
	{
		if (base.Scene.IsLoaded || Player.ActivityManager.TrialActivityInstance == null)
		{
			return;
		}
		TrialActivityInstance trialActivityInstance = Player.ActivityManager.TrialActivityInstance;
		base.LoadGroups.SafeAddRange(base.Scene.FloorInfo.Groups.Keys.ToList());
		GameData.AvatarDemoConfigData.TryGetValue(trialActivityInstance.Data.CurTrialStageId, out AvatarDemoConfigExcel value);
		if (value != null)
		{
			base.LoadGroups.Clear();
			base.LoadGroups.Add(value.MazeGroupID1);
			base.Scene.FloorInfo.Groups.TryGetValue(value.MazeGroupID1, out GroupInfo value2);
			if (value2 != null)
			{
				await LoadGroup(value2);
			}
			base.Scene.IsLoaded = true;
		}
	}

	public override async ValueTask<EntityMonster?> LoadMonster(MonsterInfo info, GroupInfo group, bool sendPacket = false)
	{
		if (info.IsClientOnly || info.IsDelete)
		{
			return null;
		}
		if (Player.ActivityManager.TrialActivityInstance == null)
		{
			return null;
		}
		TrialActivityInstance trialActivityInstance = Player.ActivityManager.TrialActivityInstance;
		GameData.AvatarDemoConfigData.TryGetValue(trialActivityInstance.Data.CurTrialStageId, out AvatarDemoConfigExcel value);
		if (value == null)
		{
			return null;
		}
		Dictionary<int, AvatarDemoConfigExcel.StageMonsterInfo> stageMonsters = value.StageMonsters1;
		if (!stageMonsters.ContainsKey(info.ID))
		{
			return null;
		}
		AvatarDemoConfigExcel.StageMonsterInfo stageMonsterInfo = stageMonsters[info.ID];
		if (!GameData.NpcMonsterDataData.ContainsKey(stageMonsterInfo.NpcMonsterId))
		{
			return null;
		}
		NPCMonsterDataExcel excel = GameData.NpcMonsterDataData[stageMonsterInfo.NpcMonsterId];
		EntityMonster entity = new EntityMonster(base.Scene, info.ToPositionProto(), info.ToRotationProto(), group.Id, info.ID, excel, info)
		{
			EventId = stageMonsterInfo.EventId,
			CustomStageId = stageMonsterInfo.EventId
		};
		await base.Scene.AddEntity(entity, sendPacket);
		return entity;
	}

	public override async ValueTask<EntityNpc?> LoadNpc(NpcInfo info, GroupInfo group, bool sendPacket = false)
	{
		await System.Threading.Tasks.Task.CompletedTask;
		return null;
	}
}
