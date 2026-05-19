using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Config;
using March7thHoney.Data.Config.AdventureAbility;
using March7thHoney.Data.Config.Scene;
using March7thHoney.Data.Config.SummonUnit;
using March7thHoney.Data.Config.Task;
using March7thHoney.Data.Excel;
using March7thHoney.Enums.Avatar;
using March7thHoney.Enums.Mission;
using March7thHoney.Enums.Scene;
using March7thHoney.GameServer.Game.Activity.Loaders;
using March7thHoney.GameServer.Game.Challenge;
using March7thHoney.GameServer.Game.Lineup;
using March7thHoney.GameServer.Game.Mission;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Game.Scene.Component;
using March7thHoney.GameServer.Game.Scene.Entity;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Scene;

public class SceneInstance
{
	public delegate ValueTask GroupPropertyUpdateArg(GroupPropertyRefreshData data);

	public PlayerInstance Player { get; set; }

	public MazePlaneExcel Excel { get; set; }

	public FloorInfo? FloorInfo { get; set; }

	public int FloorId { get; set; }

	public int PlaneId { get; set; }

	public int EntryId { get; set; }

	public int LeaveEntryId { get; set; }

	public int LastEntityId { get; set; }

	public bool IsLoaded { get; set; }

	public Dictionary<int, AvatarSceneInfo> AvatarInfo { get; set; } = new Dictionary<int, AvatarSceneInfo>();

	public int LeaderEntityId { get; set; }

	public Dictionary<int, BaseGameEntity> Entities { get; set; } = new Dictionary<int, BaseGameEntity>();

	public List<int> Groups { get; set; } = new List<int>();

	public List<EntityProp> HealingSprings { get; set; } = new List<EntityProp>();

	public SceneEntityLoader? EntityLoader { get; set; }

	public GameModeTypeEnum GameModeType { get; set; }

	public List<BaseSceneComponent> Components { get; set; } = new List<BaseSceneComponent>();

	public Dictionary<int, EntitySummonUnit> SummonUnit { get; set; } = new Dictionary<int, EntitySummonUnit>();

	public event GroupPropertyUpdateArg? GroupPropertyUpdated;

	public EntityProp? GetNearestSpring(long minDistSq)
	{
		EntityProp entityProp = null;
		long num = 0L;
		foreach (EntityProp healingSpring in HealingSprings)
		{
			long num2 = Player.Data?.Pos?.GetFast2dDist(healingSpring.Position) ?? 1000000;
			if (num2 <= minDistSq && (entityProp == null || num2 < num))
			{
				entityProp = healingSpring;
				num = num2;
			}
		}
		return entityProp;
	}

	public int ResolveDimensionId()
	{
		if (EntityLoader is StoryLineEntityLoader { DimensionId: not 0 } storyLineEntityLoader)
		{
			return storyLineEntityLoader.DimensionId;
		}
		return ResolveDimensionId(FloorInfo, EntryId, Groups);
	}

	public static int ResolveDimensionId(FloorInfo? floorInfo, int entryId = 0, IEnumerable<int>? preferredGroupIds = null)
	{
		if (floorInfo == null)
		{
			return 0;
		}
		HashSet<int> hashSet = new HashSet<int>();
		if (entryId != 0 && GameData.MapEntranceData.TryGetValue(entryId, out MapEntranceExcel value) && value.FloorID == floorInfo.FloorID)
		{
			hashSet.Add(value.StartGroupID);
		}
		if (floorInfo.StartGroupID != 0)
		{
			hashSet.Add(floorInfo.StartGroupID);
		}
		if (preferredGroupIds != null)
		{
			foreach (int item in preferredGroupIds.Where((int num) => num != 0))
			{
				hashSet.Add(item);
			}
		}
		foreach (int groupId in hashSet)
		{
			FloorDimensionInfo floorDimensionInfo = floorInfo.DimensionList.FirstOrDefault((FloorDimensionInfo info) => info.GroupIDList.Contains(groupId));
			if (floorDimensionInfo != null)
			{
				return floorDimensionInfo.ID;
			}
		}
		return floorInfo.DimensionList.FirstOrDefault((FloorDimensionInfo info) => info.ID != 0)?.ID ?? floorInfo.DimensionList.FirstOrDefault()?.ID ?? 0;
	}

	public SceneInfo ToProto()
	{
		SceneInfo sceneInfo = new SceneInfo
		{
			WorldId = ((Excel.WorldID == 100) ? 501u : ((uint)Excel.WorldID)),
			GameModeType = (uint)GameModeType,
			PlaneId = (uint)PlaneId,
			FloorId = (uint)FloorId,
			EntryId = (uint)EntryId,
			SceneMissionInfo = new MissionStatusBySceneInfo(),
			DimensionId = (uint)ResolveDimensionId(),
			GameStoryLineId = (uint)(Player.StoryLineManager?.StoryLineData.CurStoryLineId ?? 0),
			SceneIdentifier = new SceneIdentifier
			{
				FloorId = (uint)FloorId,
				GameStoryLineId = (uint)(Player.StoryLineManager?.StoryLineData.CurStoryLineId ?? 0)
			}
		};
		uint? num = Player.TrainCakeCatchManager?.GetSceneTeleportRoomOwnerUid();
		if (num.HasValue)
		{
			uint valueOrDefault = num.GetValueOrDefault();
			sceneInfo.SceneIdentifier.TeleportInfo = new TeleportInfo
			{
				TeleportId = valueOrDefault
			};
		}
		SceneEntityGroupInfo sceneEntityGroupInfo = new SceneEntityGroupInfo();
		foreach (KeyValuePair<int, AvatarSceneInfo> item in AvatarInfo)
		{
			sceneEntityGroupInfo.EntityList.Add(item.Value.ToProto());
		}
		if (sceneEntityGroupInfo.EntityList.Count > 0)
		{
			if (LeaderEntityId == 0)
			{
				LeaderEntityId = AvatarInfo.Values.First().EntityId;
			}
			sceneInfo.LeaderEntityId = (uint)LeaderEntityId;
		}
		foreach (EntitySummonUnit value5 in SummonUnit.Values)
		{
			sceneEntityGroupInfo.EntityList.Add(value5.ToProto());
		}
		sceneInfo.EntityGroupList.Add(sceneEntityGroupInfo);
		List<SceneEntityGroupInfo> list = new List<SceneEntityGroupInfo>();
		foreach (KeyValuePair<int, BaseGameEntity> entity in Entities)
		{
			if (entity.Value.GroupId == 0)
			{
				continue;
			}
			if (list.FindIndex((SceneEntityGroupInfo x) => x.GroupId == entity.Value.GroupId) == -1)
			{
				Dictionary<int, GroupPropertyConfigInfo> obj = FloorInfo?.Groups.GetValueOrDefault(entity.Value.GroupId)?.GroupPropertyMap ?? new Dictionary<int, GroupPropertyConfigInfo>();
				Dictionary<string, int> dictionary = new Dictionary<string, int>();
				Dictionary<string, int> valueOrDefault2 = Player.SceneData.GroupPropertyData.GetValueOrDefault(FloorId, new Dictionary<int, Dictionary<string, int>>()).GetValueOrDefault(entity.Value.GroupId, new Dictionary<string, int>());
				foreach (GroupPropertyConfigInfo item2 in obj.Values.Where((GroupPropertyConfigInfo x) => x.Side != GroupPropertySideEnum.ClientOnly))
				{
					dictionary.Add(item2.Name, valueOrDefault2.GetValueOrDefault(item2.Name, item2.DefaultValue));
				}
				list.Add(new SceneEntityGroupInfo
				{
					GroupId = (uint)entity.Value.GroupId,
					OPLJDFOOMGF = { (IDictionary<string, int>)dictionary },
					State = 1u
				});
			}
			list[list.FindIndex((SceneEntityGroupInfo x) => x.GroupId == entity.Value.GroupId)].EntityList.Add(entity.Value.ToProto());
		}
		foreach (int groupId in Groups)
		{
			if (list.FindIndex((SceneEntityGroupInfo x) => x.GroupId == groupId) != -1)
			{
				continue;
			}
			Dictionary<int, GroupPropertyConfigInfo> obj2 = FloorInfo?.Groups.GetValueOrDefault(groupId)?.GroupPropertyMap ?? new Dictionary<int, GroupPropertyConfigInfo>();
			Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
			Dictionary<string, int> valueOrDefault3 = Player.SceneData.GroupPropertyData.GetValueOrDefault(FloorId, new Dictionary<int, Dictionary<string, int>>()).GetValueOrDefault(groupId, new Dictionary<string, int>());
			foreach (GroupPropertyConfigInfo item3 in obj2.Values.Where((GroupPropertyConfigInfo x) => x.Side != GroupPropertySideEnum.ClientOnly))
			{
				dictionary2.Add(item3.Name, valueOrDefault3.GetValueOrDefault(item3.Name, item3.DefaultValue));
			}
			list.Add(new SceneEntityGroupInfo
			{
				GroupId = (uint)groupId,
				OPLJDFOOMGF = { (IDictionary<string, int>)dictionary2 },
				State = 1u
			});
		}
		foreach (SceneEntityGroupInfo item4 in list)
		{
			sceneInfo.EntityGroupList.Add(item4);
		}
		Player.SceneData.CustomSaveData.TryGetValue(EntryId, out Dictionary<int, string> value);
		if (value != null)
		{
			foreach (KeyValuePair<int, string> item5 in value)
			{
				sceneInfo.CustomDataList.Add(new CustomSaveData
				{
					GroupId = (uint)item5.Key,
					SaveData = item5.Value
				});
			}
		}
		Player.SceneData.FloorSavedData.TryGetValue(FloorId, out Dictionary<string, int> value2);
		bool flag = GameData.ContentPackageConfigData.Values.Any((ContentPackageConfigExcel pkg) => pkg.MainMissionIDList.Count > 0 && pkg.TouchesFloor(FloorId));
		foreach (FloorSavedValueInfo item6 in FloorInfo?.FloorSavedValue ?? new List<FloorSavedValueInfo>())
		{
			if (value2 != null && value2.TryGetValue(item6.Name, out var value3))
			{
				sceneInfo.FloorSavedData[item6.Name] = value3;
			}
			else if (item6.Name.Contains("_IsHidden"))
			{
				sceneInfo.FloorSavedData[item6.Name] = 0;
			}
			else if (flag && item6.DefaultValue == 0)
			{
				sceneInfo.FloorSavedData[item6.Name] = 1;
			}
			else
			{
				sceneInfo.FloorSavedData[item6.Name] = item6.DefaultValue;
			}
		}
		foreach (KeyValuePair<string, int> item7 in value2 ?? new Dictionary<string, int>())
		{
			sceneInfo.FloorSavedData[item7.Key] = item7.Value;
		}
		Player.MissionManager.OnLoadScene(sceneInfo);
		if (!ConfigManager.Config.ServerOption.AutoLightSection)
		{
			Player.SceneData.UnlockSectionIdList.TryGetValue(FloorId, out List<int> value4);
			if (value4 != null)
			{
				foreach (int item8 in value4)
				{
					sceneInfo.LightenSectionList.Add((uint)item8);
				}
			}
		}
		else
		{
			GameData.GetFloorInfo(PlaneId, FloorId, out FloorInfo outer);
			sceneInfo.LightenSectionList.AddRange(outer.MapSections.Select((int x) => (uint)x));
		}
		return sceneInfo;
	}

	public SceneInstance(PlayerInstance player, MazePlaneExcel excel, int floorId, int entryId)
	{
		Player = player;
		Excel = excel;
		PlaneId = excel.PlaneID;
		FloorId = floorId;
		EntryId = entryId;
		LeaveEntryId = 0;
		GameData.GetFloorInfo(PlaneId, FloorId, out FloorInfo outer);
		FloorInfo = outer;
		if (FloorInfo == null)
		{
			return;
		}
		GameModeType = (GameModeTypeEnum)excel.PlaneType;
		switch (Excel.PlaneType)
		{
		case PlaneTypeEnum.Rogue:
			EntityLoader = new SceneEntityLoader(this);
			break;
		case PlaneTypeEnum.Challenge:
			EntityLoader = new ChallengeEntityLoader(this, Player);
			break;
		case PlaneTypeEnum.TrialActivity:
			EntityLoader = new TrialActivityEntityLoader(this, Player);
			break;
		default:
		{
			StoryLineManager? storyLineManager = Player.StoryLineManager;
			EntityLoader = ((storyLineManager == null || storyLineManager.StoryLineData.CurStoryLineId != 0) ? new StoryLineEntityLoader(this) : new SceneEntityLoader(this));
			break;
		}
		}
		foreach (LevelFeatureTypeEnum item in outer.LevelFeatureModules.ToHashSet())
		{
			if (item == LevelFeatureTypeEnum.RotatableRegion)
			{
				Components.Add(new RotatableRegionSceneComponent(this));
			}
		}
		if (GameData.SceneRainbowGroupPropertyData.FloorProperty.ContainsKey(FloorId))
		{
			Components.Add(new RainbowSceneComponent(this));
		}
		System.Threading.Tasks.Task.Run(async delegate
		{
			await EntityLoader.LoadEntity();
		}).Wait();
		Player.TaskManager?.SceneTaskTrigger.TriggerFloor(PlaneId, FloorId);
		InitializeComponents();
	}

	public async ValueTask<GroupPropertyRefreshData> UpdateGroupProperty(int groupId, string name, int value, bool callEvent = true)
	{
		if (!Player.SceneData.GroupPropertyData.TryGetValue(FloorId, out Dictionary<int, Dictionary<string, int>> value2))
		{
			value2 = new Dictionary<int, Dictionary<string, int>>();
			Player.SceneData.GroupPropertyData[FloorId] = value2;
		}
		GroupInfo group = FloorInfo?.Groups.GetValueOrDefault(groupId);
		if (group == null)
		{
			return new GroupPropertyRefreshData(groupId, name, 0, value);
		}
		GroupPropertyConfigInfo groupPropertyConfigInfo = group.GroupPropertyMap.Values.FirstOrDefault((GroupPropertyConfigInfo x) => x.Name == name);
		if (groupPropertyConfigInfo == null)
		{
			return new GroupPropertyRefreshData(groupId, name, 0, value);
		}
		if (!value2.TryGetValue(groupId, out var value3))
		{
			value3 = (value2[groupId] = new Dictionary<string, int>());
		}
		int valueOrDefault = value3.GetValueOrDefault(name, groupPropertyConfigInfo.DefaultValue);
		value3[name] = value;
		GroupPropertyRefreshData res = new GroupPropertyRefreshData(groupId, name, valueOrDefault, value);
		await Player.SendPacket(new PacketSceneGroupRefreshScNotify(this, new List<GroupPropertyRefreshData>(1) { res }));
		if (callEvent && this.GroupPropertyUpdated != null)
		{
			await this.GroupPropertyUpdated(res);
		}
		if (name == "SGP_PuzzleState" && group.ControlFloorSavedValue.Count > 0)
		{
			foreach (string item in group.ControlFloorSavedValue)
			{
				await UpdateFloorSavedValue(item, value);
			}
		}
		return res;
	}

	public async ValueTask UpdateFloorSavedValue(string name, int value)
	{
		if (!Player.SceneData.FloorSavedData.TryGetValue(FloorId, out Dictionary<string, int> value2))
		{
			value2 = new Dictionary<string, int>();
			Player.SceneData.FloorSavedData[FloorId] = value2;
		}
		if (!(FloorInfo?.FloorSavedValue.All((FloorSavedValueInfo x) => x.Name != name) ?? false))
		{
			value2[name] = value;
			await Player.SendPacket(new PacketUpdateFloorSavedValueNotify(name, value, Player));
			await Player.MissionManager.HandleFinishType(MissionFinishTypeEnum.FloorSavedValue);
		}
	}

	public int GetFloorSavedValue(string name)
	{
		return Player.SceneData.GetFloorSavedValue(FloorId, name);
	}

	public int GetGroupProperty(int groupId, string name)
	{
		if (!Player.SceneData.GroupPropertyData.TryGetValue(FloorId, out Dictionary<int, Dictionary<string, int>> value))
		{
			value = new Dictionary<int, Dictionary<string, int>>();
			Player.SceneData.GroupPropertyData[FloorId] = value;
		}
		if (!value.TryGetValue(groupId, out var value2))
		{
			value2 = (value[groupId] = new Dictionary<string, int>());
		}
		GroupPropertyConfigInfo groupPropertyConfigInfo = FloorInfo?.Groups.GetValueOrDefault(groupId)?.GroupPropertyMap.Values.FirstOrDefault((GroupPropertyConfigInfo x) => x.Name == name);
		if (groupPropertyConfigInfo == null)
		{
			return 0;
		}
		return value2.GetValueOrDefault(name, groupPropertyConfigInfo.DefaultValue);
	}

	public async ValueTask SyncLineup(bool notSendPacket = false)
	{
		List<AvatarSceneInfo> list = AvatarInfo.Values.ToList();
		AvatarInfo.Clear();
		bool sendPacket = false;
		List<BaseGameEntity> addAvatar = new List<BaseGameEntity>();
		List<BaseGameEntity> removeAvatar = new List<BaseGameEntity>();
		List<AvatarLineupData> list2 = Player.LineupManager?.GetAvatarsFromCurTeam() ?? new List<AvatarLineupData>();
		foreach (AvatarSceneInfo sceneInfo in list)
		{
			if (list2.FindIndex((AvatarLineupData x) => x.AvatarInfo.BaseAvatarId == sceneInfo.AvatarInfo.BaseAvatarId) != -1)
			{
				AvatarInfo.Add(sceneInfo.EntityId, sceneInfo);
				continue;
			}
			removeAvatar.Add(sceneInfo);
			sendPacket = true;
		}
		foreach (AvatarLineupData avatar in list2)
		{
			if (!AvatarInfo.Any<KeyValuePair<int, AvatarSceneInfo>>((KeyValuePair<int, AvatarSceneInfo> x) => x.Value.AvatarInfo.BaseAvatarId == avatar.AvatarInfo.BaseAvatarId))
			{
				AvatarSceneInfo avatarSceneInfo = new AvatarSceneInfo(avatar.AvatarInfo, avatar.AvatarType, Player)
				{
					EntityId = ++LastEntityId
				};
				AvatarInfo.Add(avatarSceneInfo.EntityId, avatarSceneInfo);
				addAvatar.Add(avatarSceneInfo);
				sendPacket = true;
			}
		}
		foreach (BaseGameEntity item in removeAvatar)
		{
			Entities.Remove(item.EntityId);
			if (item is AvatarSceneInfo avatarSceneInfo2)
			{
				await avatarSceneInfo2.OnDestroyInstance();
			}
		}
		foreach (BaseGameEntity item2 in addAvatar)
		{
			Entities.Add(item2.EntityId, item2);
		}
		if (AvatarInfo.Count != 0)
		{
			int? leaderAvatarId = Player.LineupManager?.GetCurLineup()?.LeaderAvatarId;
			AvatarSceneInfo avatarSceneInfo3 = AvatarInfo.Values.FirstOrDefault((AvatarSceneInfo x) => x.AvatarInfo.BaseAvatarId == leaderAvatarId);
			if (avatarSceneInfo3 == null)
			{
				avatarSceneInfo3 = AvatarInfo.Values.First();
				Player.LineupManager.GetCurLineup().LeaderAvatarId = avatarSceneInfo3.AvatarInfo.BaseAvatarId;
			}
			LeaderEntityId = avatarSceneInfo3.EntityId;
			if (sendPacket && !notSendPacket)
			{
				await Player.SendPacket(new PacketSceneGroupRefreshScNotify(Player, addAvatar, removeAvatar));
			}
		}
	}

	public void SyncGroupInfo()
	{
		EntityLoader?.SyncEntity();
	}

	public async ValueTask OnUseSkill(SceneCastSkillCsReq req)
	{
		foreach (AvatarSceneInfo entity in Entities.Values.OfType<AvatarSceneInfo>())
		{
			if (!GameData.AvatarConfigData.TryGetValue(entity.AvatarInfo.AvatarId, out AvatarConfigExcel value))
			{
				continue;
			}
			GameData.AdventureAbilityConfigListData.TryGetValue(value.AdventurePlayerID, out AdventureAbilityConfigListInfo avatarAbility);
			if (avatarAbility == null)
			{
				continue;
			}
			string[] array = entity.Modifiers.ToArray();
			foreach (string text in array)
			{
				if (GameData.AdventureModifierData.TryGetValue(text, out AdventureModifierConfig value2) && value2.OnAfterLocalPlayerUseSkill.Count > 0)
				{
					await Player.TaskManager.AbilityLevelTask.TriggerTasks(avatarAbility, value2.OnAfterLocalPlayerUseSkill, entity, new List<BaseGameEntity>(), req, text);
				}
			}
			avatarAbility = null;
		}
	}

	public async ValueTask OnChangeLeader(int curBaseAvatarId)
	{
		foreach (AvatarSceneInfo entity in Entities.Values.OfType<AvatarSceneInfo>())
		{
			if (!GameData.AvatarConfigData.TryGetValue(entity.AvatarInfo.AvatarId, out AvatarConfigExcel value))
			{
				continue;
			}
			GameData.AdventureAbilityConfigListData.TryGetValue(value.AdventurePlayerID, out AdventureAbilityConfigListInfo avatarAbility);
			if (avatarAbility == null)
			{
				continue;
			}
			string[] array = entity.Modifiers.ToArray();
			foreach (string text in array)
			{
				if (GameData.AdventureModifierData.TryGetValue(text, out AdventureModifierConfig value2) && value2.OnTeamLeaderChange.Count > 0)
				{
					await Player.TaskManager.AbilityLevelTask.TriggerTasks(avatarAbility, value2.OnTeamLeaderChange, entity, new List<BaseGameEntity>(), new SceneCastSkillCsReq
					{
						CastEntityId = (uint)entity.EntityId
					}, text);
				}
			}
			if (curBaseAvatarId == entity.AvatarInfo.BaseAvatarId)
			{
				continue;
			}
			array = entity.Modifiers.ToArray();
			foreach (string text2 in array)
			{
				if (GameData.AdventureModifierData.TryGetValue(text2, out AdventureModifierConfig value3) && value3.OnUnstage.Count > 0)
				{
					await Player.TaskManager.AbilityLevelTask.TriggerTasks(avatarAbility, value3.OnUnstage, entity, new List<BaseGameEntity>(), new SceneCastSkillCsReq
					{
						CastEntityId = (uint)entity.EntityId
					}, text2);
				}
			}
			avatarAbility = null;
		}
	}

	public async ValueTask OnDestroy()
	{
		foreach (AvatarSceneInfo value in AvatarInfo.Values)
		{
			await value.OnDestroyInstance();
		}
	}

	public async ValueTask InitializeComponents()
	{
		foreach (BaseSceneComponent component in Components)
		{
			await component.Initialize();
		}
	}

	public T? GetComponent<T>() where T : BaseSceneComponent
	{
		return Components.FirstOrDefault((BaseSceneComponent x) => x is T) as T;
	}

	public async ValueTask AddEntity(BaseGameEntity entity)
	{
		await AddEntity(entity, IsLoaded);
	}

	public async ValueTask AddEntity(BaseGameEntity entity, bool sendPacket)
	{
		if (entity.EntityId == 0)
		{
			entity.EntityId = ++LastEntityId;
			Entities.Add(entity.EntityId, entity);
			if (sendPacket)
			{
				await Player.SendPacket(new PacketSceneGroupRefreshScNotify(Player, entity));
			}
		}
	}

	public async ValueTask<Retcode> AddSummonUnitEntity(EntitySummonUnit entity)
	{
		if (entity.EntityId != 0)
		{
			return Retcode.RetServerInternalError;
		}
		entity.EntityId = ++LastEntityId;
		if (!GameData.SummonUnitDataData.TryGetValue(entity.SummonUnitId, out SummonUnitDataExcel value))
		{
			return Retcode.RetMonsterConfigNotExist;
		}
		int summonUnitKey = ((value.UniqueGroup != SummonUnitUniqueGroupEnum.None) ? 1 : value.ID);
		if (SummonUnit.TryGetValue(summonUnitKey, out EntitySummonUnit oldSummonUnit))
		{
			foreach (BaseGameEntity item in Entities.Values.Where((BaseGameEntity x) => x is EntityMonster))
			{
				EntityMonster monster = item as EntityMonster;
				List<SceneBuff> list = monster.BuffList.ToList();
				foreach (SceneBuff item2 in list)
				{
					if (item2.SummonUnitEntityId == oldSummonUnit.EntityId)
					{
						await monster.RemoveBuff(item2.BuffId);
					}
				}
			}
			await Player.SendPacket(new PacketSceneGroupRefreshScNotify(Player, null, oldSummonUnit));
			SummonUnit.Remove(summonUnitKey);
			Entities.Remove(oldSummonUnit.EntityId);
		}
		await Player.SendPacket(new PacketSceneGroupRefreshScNotify(Player, entity));
		Entities[entity.EntityId] = entity;
		SummonUnit[summonUnitKey] = entity;
		return Retcode.RetSucc;
	}

	public async ValueTask RemoveEntity(BaseGameEntity monster)
	{
		await RemoveEntity(monster, IsLoaded);
	}

	public async ValueTask RemoveEntity(BaseGameEntity monster, bool sendPacket)
	{
		Entities.Remove(monster.EntityId);
		if (sendPacket)
		{
			await Player.SendPacket(new PacketSceneGroupRefreshScNotify(Player, null, monster));
		}
	}

	public List<T> GetEntitiesInGroup<T>(int groupId)
	{
		List<T> list = new List<T>();
		foreach (KeyValuePair<int, BaseGameEntity> entity in Entities)
		{
			if (entity.Value.GroupId == groupId && entity.Value is T item)
			{
				list.Add(item);
			}
		}
		return list;
	}

	public async ValueTask<Retcode> TriggerSummonUnit(int entityId, string triggerName, List<uint> targetIds)
	{
		EntitySummonUnit summonUnit = SummonUnit.Values.FirstOrDefault((EntitySummonUnit x) => x.EntityId == entityId);
		if (summonUnit == null)
		{
			return Retcode.RetSceneEntityNotExist;
		}
		UnitCustomTriggerConfigInfo trigger = summonUnit.TriggerList.Find((UnitCustomTriggerConfigInfo x) => x.TriggerName == triggerName);
		if (trigger == null)
		{
			return Retcode.RetSceneUseSkillFail;
		}
		await Player.SendPacket(new PacketRefreshTriggerByClientScNotify(triggerName, (uint)summonUnit.EntityId, targetIds));
		List<BaseGameEntity> list = new List<BaseGameEntity>();
		List<BaseGameEntity> list2 = new List<BaseGameEntity>();
		foreach (uint targetId in targetIds)
		{
			if (!Entities.TryGetValue((int)targetId, out BaseGameEntity value))
			{
				continue;
			}
			EntityMonster entityMonster = null;
			EntityProp entityProp = null;
			if (!(value is EntityMonster entityMonster2))
			{
				if (value is EntityProp entityProp2)
				{
					entityProp = entityProp2;
				}
			}
			else
			{
				entityMonster = entityMonster2;
			}
			if (entityMonster != null)
			{
				if (!entityMonster.IsAlive || summonUnit.CaughtEntityIds.Contains(entityMonster.EntityId))
				{
					continue;
				}
				summonUnit.CaughtEntityIds.Add(entityMonster.EntityId);
				list.Add(entityMonster);
			}
			if (entityProp != null && !summonUnit.CaughtEntityIds.Contains(entityProp.EntityId))
			{
				summonUnit.CaughtEntityIds.Add(entityProp.EntityId);
				list.Add(entityProp);
			}
		}
		foreach (BaseGameEntity value2 in Entities.Values)
		{
			if (value2 is EntityMonster entityMonster3 && summonUnit.CaughtEntityIds.Contains(entityMonster3.EntityId) && !list.Contains(entityMonster3))
			{
				summonUnit.CaughtEntityIds.Remove(entityMonster3.EntityId);
				list2.Add(entityMonster3);
			}
		}
		if (list.Count > 0)
		{
			List<TaskConfigInfo> onTriggerEnter = trigger.OnTriggerEnter;
			Player.TaskManager.SummonUnitLevelTask.TriggerTasks(onTriggerEnter, list, summonUnit);
		}
		if (list2.Count <= 0)
		{
			return Retcode.RetSucc;
		}
		List<TaskConfigInfo> onTriggerExit = trigger.OnTriggerExit;
		Player.TaskManager.SummonUnitLevelTask.TriggerTasks(onTriggerExit, list2, summonUnit);
		return Retcode.RetSucc;
	}

	public async ValueTask RemoveSummonUnitById(int summonUnitId)
	{
		KeyValuePair<int, EntitySummonUnit> summonUnit = SummonUnit.FirstOrDefault<KeyValuePair<int, EntitySummonUnit>>((KeyValuePair<int, EntitySummonUnit> x) => x.Value.SummonUnitId == summonUnitId);
		if (summonUnit.Value == null)
		{
			return;
		}
		await Player.SendPacket(new PacketSceneGroupRefreshScNotify(Player, null, summonUnit.Value));
		SummonUnit.Remove(summonUnit.Key);
		Entities.Remove(summonUnit.Value.EntityId);
		foreach (BaseGameEntity item in Entities.Values.Where((BaseGameEntity x) => x is EntityMonster))
		{
			EntityMonster monster = item as EntityMonster;
			List<SceneBuff> list = monster.BuffList.ToList();
			foreach (SceneBuff item2 in list)
			{
				if (item2.SummonUnitEntityId == summonUnit.Value.EntityId)
				{
					await monster.RemoveBuff(item2.BuffId);
				}
			}
		}
	}

	public async ValueTask OnEnterStage()
	{
		List<BaseGameEntity> removeEntities = new List<BaseGameEntity>();
		KeyValuePair<int, EntitySummonUnit>[] array = SummonUnit.ToArray();
		for (int i = 0; i < array.Length; i++)
		{
			KeyValuePair<int, EntitySummonUnit> unit = array[i];
			if (!GameData.SummonUnitDataData.TryGetValue(unit.Value.SummonUnitId, out SummonUnitDataExcel value) || !value.DestroyOnEnterBattle)
			{
				continue;
			}
			foreach (BaseGameEntity item in Entities.Values.Where((BaseGameEntity x) => x is EntityMonster))
			{
				EntityMonster monster = item as EntityMonster;
				List<SceneBuff> list = monster.BuffList.ToList();
				foreach (SceneBuff item2 in list)
				{
					if (item2.SummonUnitEntityId == unit.Value.EntityId)
					{
						await monster.RemoveBuff(item2.BuffId);
					}
				}
			}
			removeEntities.Add(unit.Value);
			SummonUnit.Remove(unit.Key);
			Entities.Remove(unit.Value.EntityId);
		}
		await Player.SendPacket(new PacketSceneGroupRefreshScNotify(Player, new List<BaseGameEntity>(), removeEntities));
	}

	public async ValueTask OnHeartBeat()
	{
		foreach (EntityMonster gameEntity in (from x in Entities.Values.Clone()
			where x is EntityMonster
			select x).OfType<EntityMonster>())
		{
			foreach (SceneBuff item in from sceneBuff in gameEntity.BuffList.Clone()
				where sceneBuff.IsExpired()
				select sceneBuff)
			{
				await gameEntity.RemoveBuff(item.BuffId);
			}
		}
		foreach (AvatarSceneInfo gameEntity2 in AvatarInfo.Values.Clone())
		{
			foreach (SceneBuff item2 in from sceneBuff in gameEntity2.BuffList.Clone()
				where sceneBuff.IsExpired()
				select sceneBuff)
			{
				await gameEntity2.RemoveBuff(item2.BuffId);
			}
		}
		foreach (EntitySummonUnit value in SummonUnit.Values)
		{
			if (value.LifeTimeMs != -1 && value.CreateTimeMs + value.LifeTimeMs < Extensions.GetUnixMs())
			{
				await RemoveSummonUnitById(value.SummonUnitId);
			}
		}
	}
}
