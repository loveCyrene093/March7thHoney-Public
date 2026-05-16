using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Config;
using March7thHoney.Data.Config.Scene;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Quests;
using March7thHoney.Database.Scene;
using March7thHoney.Enums;
using March7thHoney.Enums.Mission;
using March7thHoney.Enums.Scene;
using March7thHoney.GameServer.Game.Scene.Entity;
using March7thHoney.GameServer.Server.Packet.Send.Scene;

namespace March7thHoney.GameServer.Game.Scene;

public class SceneEntityLoader(SceneInstance scene)
{
	public SceneInstance Scene { get; set; } = scene;

	public List<int> LoadGroups { get; set; } = new List<int>();

	public virtual async ValueTask LoadEntity()
	{
		if (Scene.IsLoaded)
		{
			return;
		}
		FloorDimensionInfo floorDimensionInfo = Scene.FloorInfo?.DimensionList.Find((FloorDimensionInfo x) => x.ID == 0);
		if (floorDimensionInfo == null)
		{
			return;
		}
		LoadGroups.AddRange(floorDimensionInfo.GroupIDList);
		foreach (GroupInfo item in from @group in Scene.FloorInfo?.Groups.Values
			where @group.LoadSide != GroupLoadSideEnum.Client
			where !@group.GroupName.Contains("DeployPuzzle_Repeat_Area")
			where !@group.GroupName.Contains("TrainVisitor")
			where !@group.GroupName.Contains("TrainVisiter")
			select @group)
		{
			await LoadGroup(item);
		}
		Scene.IsLoaded = true;
	}

	public virtual async ValueTask SyncEntity()
	{
		bool refreshed = false;
		List<int> oldGroupId = new List<int>();
		foreach (BaseGameEntity item in Scene.Entities.Values.Where((BaseGameEntity baseGameEntity) => !oldGroupId.Contains(baseGameEntity.GroupId)))
		{
			oldGroupId.Add(item.GroupId);
		}
		List<BaseGameEntity> removeList = new List<BaseGameEntity>();
		List<BaseGameEntity> addList = new List<BaseGameEntity>();
		foreach (GroupInfo group in from groupInfo in Scene.FloorInfo.Groups.Values
			where groupInfo.LoadSide != GroupLoadSideEnum.Client
			where !groupInfo.GroupName.Contains("TrainVisitor")
			where !groupInfo.GroupName.Contains("DeployPuzzle_Repeat_Area")
			where !groupInfo.GroupName.Contains("TrainVisiter")
			select groupInfo)
		{
			if (oldGroupId.Contains(group.Id))
			{
				if (group.ForceUnloadCondition.IsTrue(Scene.Player.MissionManager.Data, defaultResult: false) || group.UnloadCondition.IsTrue(Scene.Player.MissionManager.Data, defaultResult: false))
				{
					foreach (BaseGameEntity entity in Scene.Entities.Values.Where((BaseGameEntity baseGameEntity) => baseGameEntity.GroupId == group.Id))
					{
						await Scene.RemoveEntity(entity, sendPacket: false);
						removeList.Add(entity);
						refreshed = true;
					}
					Scene.Groups.Remove(group.Id);
				}
				else if (group.OwnerMainMissionID != 0 && Scene.Player.MissionManager.GetMainMissionStatus(group.OwnerMainMissionID) != MissionPhaseEnum.Accept)
				{
					foreach (BaseGameEntity entity in Scene.Entities.Values.Where((BaseGameEntity baseGameEntity) => baseGameEntity.GroupId == group.Id))
					{
						await Scene.RemoveEntity(entity, sendPacket: false);
						removeList.Add(entity);
						refreshed = true;
					}
					Scene.Groups.Remove(group.Id);
				}
				else if (!group.SavedValueCondition.IsTrue(Scene.Player.SceneData.GetFloorSavedValues(Scene.FloorId)))
				{
					foreach (BaseGameEntity entity in Scene.Entities.Values.Where((BaseGameEntity baseGameEntity) => baseGameEntity.GroupId == group.Id))
					{
						await Scene.RemoveEntity(entity, sendPacket: false);
						removeList.Add(entity);
						refreshed = true;
					}
					Scene.Groups.Remove(group.Id);
				}
				else
				{
					if (group.RelatedBattleId.Count <= 0 || Scene.Player.MissionManager.GetRunningSubMissionList().Any((SubMissionInfo x) => x.FinishType == MissionFinishTypeEnum.StageWin && group.RelatedBattleId.Contains(x.ParamInt1)))
					{
						continue;
					}
					foreach (BaseGameEntity entity in Scene.Entities.Values.Where((BaseGameEntity baseGameEntity) => baseGameEntity.GroupId == group.Id))
					{
						await Scene.RemoveEntity(entity, sendPacket: false);
						removeList.Add(entity);
						refreshed = true;
					}
					Scene.Groups.Remove(group.Id);
				}
			}
			else
			{
				List<BaseGameEntity> list = await LoadGroup(group);
				refreshed = list != null || refreshed;
				addList.AddRange(list ?? new List<BaseGameEntity>());
			}
		}
		if (refreshed && (addList.Count > 0 || removeList.Count > 0))
		{
			await Scene.Player.SendPacket(new PacketSceneGroupRefreshScNotify(Scene.Player, addList, removeList));
		}
	}

	public virtual async ValueTask<List<BaseGameEntity>?> LoadGroup(GroupInfo info, bool forceLoad = false)
	{
		if (!LoadGroups.Contains(info.Id))
		{
			return null;
		}
		MissionData data = Scene.Player.MissionManager.Data;
		if (info.LoadSide == GroupLoadSideEnum.Client)
		{
			return null;
		}
		if (info.GroupName.Contains("TrainVisitor"))
		{
			return null;
		}
		if (info.GroupName.Contains("DeployPuzzle_Repeat_Area"))
		{
			return null;
		}
		if (info.GroupName.Contains("TrainVisiter"))
		{
			return null;
		}
		if (info.SystemUnlockCondition != null)
		{
			bool flag = info.SystemUnlockCondition.Operation != OperationEnum.Or;
			foreach (int condition in info.SystemUnlockCondition.Conditions)
			{
				GameData.GroupSystemUnlockDataData.TryGetValue(condition, out GroupSystemUnlockDataExcel value);
				if (value != null)
				{
					bool flag2 = Scene.Player.QuestManager?.UnlockHandler.GetUnlockStatus(value.UnlockID) ?? false;
					if (info.SystemUnlockCondition.Operation == OperationEnum.Or && flag2)
					{
						flag = true;
						break;
					}
					if (info.SystemUnlockCondition.Operation == OperationEnum.And && !flag2)
					{
						flag = false;
						break;
					}
					if (info.SystemUnlockCondition.Operation == OperationEnum.Not && flag2)
					{
						flag = false;
						break;
					}
				}
			}
			if (!flag)
			{
				return null;
			}
		}
		if (info.OwnerMainMissionID != 0 && Scene.Player.MissionManager.GetMainMissionStatus(info.OwnerMainMissionID) != MissionPhaseEnum.Accept)
		{
			return null;
		}
		if ((!info.LoadCondition.IsTrue(data) || info.UnloadCondition.IsTrue(data, defaultResult: false) || info.ForceUnloadCondition.IsTrue(data, defaultResult: false)) && !forceLoad)
		{
			return null;
		}
		if (!info.SavedValueCondition.IsTrue(Scene.Player.SceneData.FloorSavedData.GetValueOrDefault(Scene.FloorId, new Dictionary<string, int>())) && !forceLoad)
		{
			return null;
		}
		if (Scene.Entities.Values.ToList().FindIndex((BaseGameEntity x) => x.GroupId == info.Id) != -1)
		{
			return null;
		}
		if (info.RelatedBattleId.Count > 0 && !Scene.Player.MissionManager.GetRunningSubMissionList().Any((SubMissionInfo x) => x.FinishType == MissionFinishTypeEnum.StageWin && info.RelatedBattleId.Contains(x.ParamInt1)))
		{
			return null;
		}
		Scene.Groups.Add(info.Id);
		List<BaseGameEntity> entityList = new List<BaseGameEntity>();
		foreach (NpcInfo nPC in info.NPCList)
		{
			try
			{
				EntityNpc entityNpc = await LoadNpc(nPC, info);
				if (entityNpc != null)
				{
					entityList.Add(entityNpc);
				}
			}
			catch
			{
			}
		}
		foreach (MonsterInfo monster in info.MonsterList)
		{
			try
			{
				EntityMonster entityMonster = await LoadMonster(monster, info);
				if (entityMonster != null)
				{
					entityList.Add(entityMonster);
				}
			}
			catch
			{
			}
		}
		foreach (PropInfo prop in info.PropList)
		{
			try
			{
				EntityProp entityProp = await LoadProp(prop, info);
				if (entityProp != null)
				{
					entityList.Add(entityProp);
				}
			}
			catch
			{
			}
		}
		return entityList;
	}

	public virtual async ValueTask<List<BaseGameEntity>?> LoadGroup(int groupId, bool sendPacket = true)
	{
		GroupInfo value = default(GroupInfo);
		GroupInfo groupInfo = ((Scene.FloorInfo?.Groups.TryGetValue(groupId, out value) ?? false) ? value : null);
		if (groupInfo == null)
		{
			return null;
		}
		List<BaseGameEntity> entities = await LoadGroup(groupInfo, forceLoad: true);
		if (sendPacket && entities != null && entities.Count > 0)
		{
			await Scene.Player.SendPacket(new PacketSceneGroupRefreshScNotify(Scene.Player, entities));
		}
		return entities;
	}

	public virtual async ValueTask UnloadGroup(int groupId)
	{
		GroupInfo value = default(GroupInfo);
		GroupInfo group = ((Scene.FloorInfo?.Groups.TryGetValue(groupId, out value) ?? false) ? value : null);
		if (group == null)
		{
			return;
		}
		List<BaseGameEntity> removeList = new List<BaseGameEntity>();
		bool flag = false;
		foreach (BaseGameEntity entity in Scene.Entities.Values)
		{
			if (entity.GroupId == group.Id)
			{
				await Scene.RemoveEntity(entity, sendPacket: false);
				removeList.Add(entity);
				flag = true;
			}
		}
		Scene.Groups.Remove(group.Id);
		if (flag)
		{
			await Scene.Player.SendPacket(new PacketSceneGroupRefreshScNotify(Scene.Player, null, removeList));
		}
	}

	public virtual async ValueTask<EntityNpc?> LoadNpc(NpcInfo info, GroupInfo group, bool sendPacket = false)
	{
		if (info.IsClientOnly || info.IsDelete)
		{
			return null;
		}
		if (!GameData.NpcDataData.ContainsKey(info.NPCID))
		{
			return null;
		}
		EntityNpc npc = new EntityNpc(Scene, group, info);
		await Scene.AddEntity(npc, sendPacket);
		return npc;
	}

	public virtual async ValueTask<EntityMonster?> LoadMonster(MonsterInfo info, GroupInfo group, bool sendPacket = false)
	{
		if (info.IsClientOnly || info.IsDelete)
		{
			return null;
		}
		GameData.NpcMonsterDataData.TryGetValue(info.NPCMonsterID, out NPCMonsterDataExcel value);
		if (value == null)
		{
			return null;
		}
		EntityMonster entity = new EntityMonster(Scene, info.ToPositionProto(), info.ToRotationProto(), group.Id, info.ID, value, info);
		await Scene.AddEntity(entity, sendPacket);
		return entity;
	}

	public virtual async ValueTask<EntityProp?> LoadProp(PropInfo info, GroupInfo group, bool sendPacket = false)
	{
		if (info.IsDelete)
		{
			return null;
		}
		GameData.MazePropData.TryGetValue(info.PropID, out MazePropExcel value);
		if (value == null)
		{
			return null;
		}
		EntityProp prop = new EntityProp(Scene, value, group, info);
		if (value.PropType == PropTypeEnum.PROP_SPRING)
		{
			Scene.HealingSprings.Add(prop);
			await prop.SetState(PropStateEnum.CheckPointEnable);
		}
		ScenePropData scenePropData = Scene.Player.GetScenePropData(Scene.FloorId, group.Id, info.ID);
		bool flag = scenePropData != null && Scene.Excel.PlaneType != PlaneTypeEnum.Raid;
		if (flag)
		{
			prop.State = scenePropData.State;
		}
		else if (Scene.Excel.PlaneType == PlaneTypeEnum.Raid)
		{
			prop.State = info.State;
		}
		else
		{
			prop.State = ((prop.Excel.PropType == PropTypeEnum.PROP_ELEVATOR) ? PropStateEnum.Elevator1 : info.State);
		}
		ScenePropTimelineData scenePropTimelineData = Scene.Player.GetScenePropTimelineData(Scene.FloorId, group.Id, info.ID);
		prop.PropTimelineData = scenePropTimelineData;
		if (group.GroupName.Contains("Machine"))
		{
			await prop.SetState(PropStateEnum.Open);
			await Scene.AddEntity(prop, sendPacket);
			return prop;
		}
		if (!flag && prop.PropInfo.Name.Contains("Case") && prop.State == PropStateEnum.Open)
		{
			await prop.SetState(PropStateEnum.Closed);
		}
		if (prop.PropInfo.PropID == 1003)
		{
			if (prop.PropInfo.MappingInfoID != 2220)
			{
				return prop;
			}
			await prop.SetState(PropStateEnum.Open);
		}
		int propID = prop.PropInfo.PropID;
		if ((uint)(propID - 104005) <= 1u)
		{
			await prop.SetState(PropStateEnum.Open);
		}
		if (prop.Excel.PropType == PropTypeEnum.PROP_DESTRUCT && prop.State == PropStateEnum.Open)
		{
			return null;
		}
		await Scene.AddEntity(prop, sendPacket);
		return prop;
	}
}
