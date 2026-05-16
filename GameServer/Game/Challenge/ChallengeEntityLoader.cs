using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Config.Scene;
using March7thHoney.Data.Excel;
using March7thHoney.Enums.Scene;
using March7thHoney.GameServer.Game.Challenge.Definitions;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Game.Scene;
using March7thHoney.GameServer.Game.Scene.Entity;
using March7thHoney.Proto.ServerSide;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Challenge;

public class ChallengeEntityLoader(SceneInstance scene, PlayerInstance player) : SceneEntityLoader(scene)
{
	public PlayerInstance Player = player;

	public override async ValueTask LoadEntity()
	{
		if (base.Scene.IsLoaded || Player.ChallengeManager.ChallengeInstance == null)
		{
			return;
		}
		BaseChallengeInstance instance = Player.ChallengeManager.ChallengeInstance;
		base.LoadGroups.SafeAddRange(base.Scene.FloorInfo.Groups.Keys.ToList());
		Dictionary<int, List<ChallengeConfigExcel.ChallengeMonsterInfo>> stageMonsters = instance.GetStageMonsters();
		foreach (KeyValuePair<int, List<ChallengeConfigExcel.ChallengeMonsterInfo>> item in stageMonsters)
		{
			base.Scene.FloorInfo.Groups.TryGetValue(item.Key, out GroupInfo value);
			if (value != null)
			{
				await LoadGroup(value);
			}
		}
		SceneInstance scene = base.Scene;
		scene.LeaveEntryId = instance.Data.ChallengeTypeCase switch
		{
			ChallengeDataPb.ChallengeTypeOneofCase.Boss => 1030402, 
			ChallengeDataPb.ChallengeTypeOneofCase.Memory => 100000103, 
			ChallengeDataPb.ChallengeTypeOneofCase.Peak => 100000352, 
			ChallengeDataPb.ChallengeTypeOneofCase.Story => 102020107, 
			_ => base.Scene.LeaveEntryId, 
		};
		foreach (GroupInfo value2 in base.Scene.FloorInfo.Groups.Values)
		{
			if (value2.LoadSide == GroupLoadSideEnum.Server && value2.PropList.Count > 0 && value2.MonsterList.Count == 0)
			{
				await LoadGroup(value2);
			}
		}
		base.Scene.IsLoaded = true;
	}

	public override async ValueTask<EntityMonster?> LoadMonster(MonsterInfo info, GroupInfo group, bool sendPacket = false)
	{
		if (info.IsClientOnly || info.IsDelete)
		{
			return null;
		}
		if (Player.ChallengeManager.ChallengeInstance == null)
		{
			return null;
		}
		if (!Player.ChallengeManager.ChallengeInstance.GetStageMonsters().TryGetValue(group.Id, out List<ChallengeConfigExcel.ChallengeMonsterInfo> value))
		{
			return null;
		}
		if (value.All((ChallengeConfigExcel.ChallengeMonsterInfo x) => x.ConfigId != info.ID))
		{
			return null;
		}
		ChallengeConfigExcel.ChallengeMonsterInfo challengeMonsterInfo = value.First((ChallengeConfigExcel.ChallengeMonsterInfo x) => x.ConfigId == info.ID);
		if (!GameData.NpcMonsterDataData.TryGetValue(challengeMonsterInfo.NpcMonsterId, out NPCMonsterDataExcel value2))
		{
			return null;
		}
		EntityMonster entity = new EntityMonster(base.Scene, info.ToPositionProto(), info.ToRotationProto(), group.Id, info.ID, value2, info)
		{
			EventId = challengeMonsterInfo.EventId,
			CustomStageId = challengeMonsterInfo.EventId
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
