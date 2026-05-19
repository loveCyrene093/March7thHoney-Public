using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Config.Scene;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Avatar;
using March7thHoney.Database.Inventory;
using March7thHoney.Database.Lineup;
using March7thHoney.GameServer.Game.GridFight;
using March7thHoney.GameServer.Game.GridFight.Battle;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Game.Scene;
using March7thHoney.GameServer.Game.Scene.Entity;
using March7thHoney.GameServer.Plugin.Event;
using March7thHoney.GameServer.Server.Packet.Send.Battle;
using March7thHoney.GameServer.Server.Packet.Send.Lineup;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Battle;

public class BattleManager : BasePlayerManager
{
	public StageConfigExcel? NextBattleStageConfig { get; set; }

	public List<int> NextBattleMonsterIds { get; set; } = new List<int>();

	public BattleManager(PlayerInstance player)
		: base(player)
	{
	}

	public async ValueTask<BattleInstance?> StartBattle(BaseGameEntity attackEntity, List<BaseGameEntity> targetEntityList, bool isSkill)
	{
		if (base.Player.BattleInstance != null)
		{
			return base.Player.BattleInstance;
		}
		List<EntityMonster> targetList = new List<EntityMonster>();
		List<AvatarSceneInfo> avatarList = new List<AvatarSceneInfo>();
		List<EntityProp> list = new List<EntityProp>();
		base.Player.SceneInstance.AvatarInfo.TryGetValue(attackEntity.EntityId, out AvatarSceneInfo castAvatar);
		if (castAvatar != null)
		{
			foreach (BaseGameEntity targetEntity in targetEntityList)
			{
				if (!(targetEntity is EntityMonster item))
				{
					if (targetEntity is EntityProp item2)
					{
						list.Add(item2);
					}
				}
				else
				{
					targetList.Add(item);
				}
			}
		}
		else
		{
			if (!targetEntityList.Any((BaseGameEntity entity) => base.Player.SceneInstance.AvatarInfo.ContainsKey(entity.EntityId)))
			{
				return null;
			}
			if (base.Player.SceneInstance.Entities[attackEntity.EntityId] is EntityMonster item3)
			{
				targetList.Add(item3);
			}
		}
		if (targetList.Count == 0 && list.Count == 0)
		{
			return null;
		}
		foreach (EntityProp prop in list)
		{
			await base.Player.SceneInstance.RemoveEntity(prop);
			if (prop.Excel.IsMpRecover)
			{
				await base.Player.LineupManager.GainMp(2, sendPacket: true, SyncLineupReason.SyncReasonMpAddPropHit);
			}
			else if (prop.Excel.IsHpRecover)
			{
				base.Player.LineupManager.GetCurLineup().Heal(2000, allowRevive: false);
				await base.Player.SendPacket(new PacketSyncLineupNotify(base.Player.LineupManager.GetCurLineup()));
			}
			else if (prop.PropInfo.Name == "SpeedDestruct")
			{
				await base.Player.SceneInstance.AvatarInfo.Values.ToList().RandomElement().AddBuff(new SceneBuff(2041101, 1, -1, 15));
			}
			else
			{
				base.Player.InventoryManager.HandlePlaneEvent(prop.PropInfo.EventID);
			}
		}
		if (targetList.Count > 0)
		{
			if (!targetList.Any((EntityMonster target) => target.IsAlive))
			{
				return null;
			}
			BattleInstance battleInstance = new BattleInstance(base.Player, base.Player.LineupManager.GetCurLineup(), targetList.Where((EntityMonster x) => x.IsAlive).ToList())
			{
				WorldLevel = base.Player.Data.WorldLevel
			};
			if (NextBattleStageConfig != null)
			{
				battleInstance = new BattleInstance(base.Player, base.Player.LineupManager.GetCurLineup(), new List<StageConfigExcel>(1) { NextBattleStageConfig })
				{
					WorldLevel = base.Player.Data.WorldLevel
				};
				NextBattleStageConfig = null;
			}
			avatarList.AddRange(base.Player.LineupManager.GetCurLineup().BaseAvatars.Select((LineupAvatarInfo lineupAvatarInfo) => base.Player.SceneInstance.AvatarInfo.Values.FirstOrDefault((AvatarSceneInfo x) => x.AvatarInfo.AvatarId == lineupAvatarInfo.BaseAvatarId)).OfType<AvatarSceneInfo>());
			MazeBuff mazeBuff = null;
			if (castAvatar != null)
			{
				int owner = battleInstance.Lineup.BaseAvatars.FindIndex((LineupAvatarInfo x) => x.BaseAvatarId == castAvatar.AvatarInfo.AvatarId);
				GameData.AvatarConfigData.TryGetValue(castAvatar.AvatarInfo.AvatarId, out AvatarConfigExcel value);
				if (value != null)
				{
					mazeBuff = new MazeBuff((int)value.DamageType, 1, owner);
					mazeBuff.DynamicValues.Add("SkillIndex", (!isSkill) ? 1 : 2);
				}
			}
			else
			{
				mazeBuff = new MazeBuff(1000102, 1, -1)
				{
					WaveFlag = 1
				};
			}
			if (mazeBuff != null && mazeBuff.BuffID != 0)
			{
				battleInstance.Buffs.Add(mazeBuff);
			}
			battleInstance.AvatarInfo = avatarList;
			base.Player.ChallengeManager.ChallengeInstance?.OnBattleStart(battleInstance);
			base.Player.QuestManager.OnBattleStart(battleInstance);
			base.Player.BattleInstance = battleInstance;
			PluginEvent.InvokeOnPlayerEnterBattle(base.Player, battleInstance);
			return battleInstance;
		}
		return null;
	}

	public async ValueTask StartStage(int eventId)
	{
		if (base.Player.BattleInstance != null)
		{
			await base.Player.SendPacket(new PacketSceneEnterStageScRsp(base.Player.BattleInstance));
			return;
		}
		GameData.StageConfigData.TryGetValue(eventId, out StageConfigExcel value);
		if (value == null)
		{
			GameData.StageConfigData.TryGetValue(eventId * 10 + base.Player.Data.WorldLevel, out value);
			if (value == null)
			{
				await base.Player.SendPacket(new PacketSceneEnterStageScRsp());
				return;
			}
		}
		if (NextBattleStageConfig != null)
		{
			value = NextBattleStageConfig;
			NextBattleStageConfig = null;
		}
		BattleInstance battleInstance = new BattleInstance(base.Player, base.Player.LineupManager.GetCurLineup(), new List<StageConfigExcel>(1) { value })
		{
			WorldLevel = base.Player.Data.WorldLevel,
			EventId = eventId
		};
		List<AvatarSceneInfo> avatarInfo = base.Player.LineupManager.GetCurLineup().BaseAvatars.Select((LineupAvatarInfo item) => base.Player.SceneInstance.AvatarInfo.Values.FirstOrDefault((AvatarSceneInfo x) => x.AvatarInfo.AvatarId == item.BaseAvatarId)).OfType<AvatarSceneInfo>().ToList();
		battleInstance.AvatarInfo = avatarInfo;
		base.Player.ChallengeManager.ChallengeInstance?.OnBattleStart(battleInstance);
		base.Player.QuestManager.OnBattleStart(battleInstance);
		base.Player.BattleInstance = battleInstance;
		PluginEvent.InvokeOnPlayerEnterBattle(base.Player, battleInstance);
		await base.Player.SendPacket(new PacketSceneEnterStageScRsp(battleInstance));
		base.Player.SceneInstance?.OnEnterStage();
	}

	public async ValueTask<BattleInstance?> StartCocoonStage(int cocoonId, int wave, int worldLevel)
	{
		if (base.Player.BattleInstance != null)
		{
			return null;
		}
		if (base.Player.CalyxOverrideManager?.IsActive ?? false)
		{
			return await base.Player.CalyxOverrideManager.BuildOverrideBattle(cocoonId, wave, worldLevel);
		}
		GameData.CocoonConfigData.TryGetValue(cocoonId * 100 + worldLevel, out CocoonConfigExcel value);
		if (value == null)
		{
			return null;
		}
		wave = Math.Max(wave, 1);
		int num = value.StaminaCost * wave;
		if (base.Player.Data.Stamina < num)
		{
			return null;
		}
		List<StageConfigExcel> list = new List<StageConfigExcel>();
		for (int i = 0; i < wave; i++)
		{
			int key = value.StageIDList.RandomElement();
			GameData.StageConfigData.TryGetValue(key, out StageConfigExcel value2);
			if (value2 != null)
			{
				list.Add(value2);
			}
		}
		if (list.Count == 0)
		{
			return null;
		}
		BattleInstance battleInstance = new BattleInstance(base.Player, base.Player.LineupManager.GetCurLineup(), list)
		{
			StaminaCost = num,
			WorldLevel = value.WorldLevel,
			CocoonWave = wave,
			MappingInfoId = value.MappingInfoID
		};
		if (NextBattleStageConfig != null)
		{
			battleInstance = new BattleInstance(base.Player, base.Player.LineupManager.GetCurLineup(), new List<StageConfigExcel>(1) { NextBattleStageConfig })
			{
				WorldLevel = base.Player.Data.WorldLevel
			};
			NextBattleStageConfig = null;
		}
		List<AvatarSceneInfo> avatarInfo = base.Player.LineupManager.GetCurLineup().BaseAvatars.Select((LineupAvatarInfo item) => base.Player.SceneInstance.AvatarInfo.Values.FirstOrDefault((AvatarSceneInfo x) => x.AvatarInfo.AvatarId == item.BaseAvatarId)).OfType<AvatarSceneInfo>().ToList();
		battleInstance.AvatarInfo = avatarInfo;
		base.Player.BattleInstance = battleInstance;
		base.Player.QuestManager.OnBattleStart(battleInstance);
		PluginEvent.InvokeOnPlayerEnterBattle(base.Player, battleInstance);
		await ValueTask.CompletedTask;
		return battleInstance;
	}

	public async ValueTask<BattleInstance?> StartFarmElementStage(FarmElementConfigExcel config)
	{
		if (base.Player.BattleInstance != null)
		{
			return null;
		}
		if (base.Player.Data.Stamina < config.StaminaCost)
		{
			return null;
		}
		GameData.StageConfigData.TryGetValue(config.StageID, out StageConfigExcel value);
		if (value == null)
		{
			return null;
		}
		BattleInstance battleInstance = new BattleInstance(base.Player, base.Player.LineupManager.GetCurLineup(), new List<StageConfigExcel>(1) { value })
		{
			StaminaCost = config.StaminaCost,
			WorldLevel = config.WorldLevel,
			CocoonWave = 1,
			MappingInfoId = config.MappingInfoID
		};
		List<AvatarSceneInfo> avatarInfo = base.Player.LineupManager.GetCurLineup().BaseAvatars.Select((LineupAvatarInfo item) => base.Player.SceneInstance.AvatarInfo.Values.FirstOrDefault((AvatarSceneInfo x) => x.AvatarInfo.AvatarId == item.BaseAvatarId)).OfType<AvatarSceneInfo>().ToList();
		battleInstance.AvatarInfo = avatarInfo;
		base.Player.BattleInstance = battleInstance;
		base.Player.QuestManager.OnBattleStart(battleInstance);
		PluginEvent.InvokeOnPlayerEnterBattle(base.Player, battleInstance);
		await ValueTask.CompletedTask;
		return battleInstance;
	}

	public (Retcode, BattleInstance?) StartBattleCollege(int collegeId)
	{
		if (base.Player.BattleInstance != null)
		{
			return (Retcode.RetInBattleNow, null);
		}
		GameData.BattleCollegeConfigData.TryGetValue(collegeId, out BattleCollegeConfigExcel value);
		if (value == null)
		{
			return (Retcode.RetFail, null);
		}
		int stageID = value.StageID;
		GameData.StageConfigData.TryGetValue(stageID, out StageConfigExcel value2);
		if (value2 == null)
		{
			return (Retcode.RetStageConfigNotExist, null);
		}
		PlayerInstance player = base.Player;
		March7thHoney.Database.Lineup.LineupInfo? curLineup = base.Player.LineupManager.GetCurLineup();
		int num = 1;
		List<StageConfigExcel> list = new List<StageConfigExcel>(num);
		CollectionsMarshal.SetCount(list, num);
		CollectionsMarshal.AsSpan(list)[0] = value2;
		BattleInstance battleInstance = new BattleInstance(player, curLineup, list)
		{
			WorldLevel = base.Player.Data.WorldLevel,
			CollegeConfigExcel = value,
			AvatarInfo = new List<AvatarSceneInfo>()
		};
		base.Player.ChallengeManager.ChallengeInstance?.OnBattleStart(battleInstance);
		base.Player.QuestManager.OnBattleStart(battleInstance);
		base.Player.BattleInstance = battleInstance;
		return (Retcode.RetSucc, battleInstance);
	}

	public BattleInstance? StartGridFightBattle(object inst)
	{
		if (!(inst is GridFightInstance gridFightInstance))
		{
			return null;
		}
		return GridFightBattleModule.StartBattle(base.Player, gridFightInstance);
	}

	public async ValueTask EndBattle(PVEBattleResultCsReq req)
	{
		PluginEvent.InvokeOnPlayerQuitBattle(base.Player, req);
		if (base.Player.BattleInstance == null)
		{
			await base.Player.SendPacket(new PacketPVEBattleResultScRsp());
			return;
		}
		base.Player.BattleInstance.BattleEndStatus = req.EndStatus;
		BattleInstance battle = base.Player.BattleInstance;
		bool updateStatus = true;
		bool teleportToAnchor = false;
		int minimumHp = 0;
		List<ItemData> dropItems = new List<ItemData>();
		switch (req.EndStatus)
		{
		case BattleEndStatus.BattleEndWin:
		{
			if (battle.EntityMonsters.Count == 0)
			{
				battle.EntityMonsters = ResolveSceneMonstersByStageId(battle.StageId);
			}
			int farmEntityId = (int)base.Player.ActiveFarmElementEntityId;
			foreach (EntityMonster entityMonster in battle.EntityMonsters)
			{
				bool flag = farmEntityId != 0 && entityMonster.EntityId == farmEntityId;
				List<ItemData> list = dropItems;
				list.AddRange(await entityMonster.Kill(sendPacket: false, !flag));
			}
			if (battle.StaminaCost > 0)
			{
				await base.Player.SpendStamina(battle.StaminaCost);
			}
			break;
		}
		case BattleEndStatus.BattleEndLose:
			minimumHp = 2000;
			teleportToAnchor = true;
			break;
		default:
			teleportToAnchor = true;
			if (battle.CocoonWave > 0)
			{
				teleportToAnchor = false;
			}
			updateStatus = false;
			break;
		}
		if (updateStatus)
		{
			March7thHoney.Database.Lineup.LineupInfo curLineup = base.Player.LineupManager.GetCurLineup();
			foreach (AvatarBattleInfo battleAvatar in req.Stt.BattleAvatarList)
			{
				BaseAvatarInfo formalAvatar = base.Player.AvatarManager.GetFormalAvatar((int)battleAvatar.Id);
				AvatarProperty avatarStatus = battleAvatar.AvatarStatus;
				int value = (int)Math.Max(Math.Round(avatarStatus.LeftHp / avatarStatus.MaxHp * 10000.0), minimumHp);
				int value2 = (int)avatarStatus.LeftSp * 100;
				if (formalAvatar == null)
				{
					formalAvatar = base.Player.AvatarManager.GetTrialAvatar((int)battleAvatar.Id);
					formalAvatar?.SetCurHp(value, curLineup.LineupType != 0);
					formalAvatar?.SetCurSp(value2, curLineup.LineupType != 0);
				}
				else
				{
					formalAvatar.SetCurHp(value, curLineup.LineupType != 0);
					formalAvatar.SetCurSp(value2, curLineup.LineupType != 0);
				}
			}
			await base.Player.SendPacket(new PacketSyncLineupNotify(curLineup));
		}
		if (teleportToAnchor)
		{
			EntityProp entityProp = base.Player.SceneInstance?.GetNearestSpring(long.MaxValue);
			if (entityProp != null)
			{
				AnchorInfo anchorInfo = base.Player.SceneInstance?.FloorInfo?.GetAnchorInfo(entityProp.PropInfo.AnchorGroupID, entityProp.PropInfo.AnchorID);
				if (anchorInfo != null)
				{
					await base.Player.MoveTo(anchorInfo.ToPositionProto());
				}
			}
		}
		else if (base.Player.ActiveFarmElementEntityId != 0 && base.Player.FarmElementReturnPos != null)
		{
			await base.Player.MoveTo(base.Player.FarmElementReturnPos, base.Player.FarmElementReturnRot ?? base.Player.Data.Rot);
		}
		battle.MonsterDropItems = dropItems;
		battle.BattleResult = req;
		base.Player.BattleInstance = null;
		if (base.Player.GridFightManager?.GridFightInstance != null)
		{
			await base.Player.GridFightManager.GridFightInstance.EndBattle(battle, req);
		}
		battle.OnBattleEnd += base.Player.MissionManager.OnBattleFinish;
		await battle.TriggerOnBattleEnd();
		if (base.Player.ActivityManager.TrialActivityInstance != null && req.EndStatus == BattleEndStatus.BattleEndWin)
		{
			await base.Player.ActivityManager.TrialActivityInstance.EndActivity(TrialActivityStatus.Finish);
		}
		await base.Player.SendPacket(new PacketPVEBattleResultScRsp(req, base.Player, battle));
	}

	private List<EntityMonster> ResolveSceneMonstersByStageId(int stageId)
	{
		if (stageId == 0 || base.Player.SceneInstance == null)
		{
			return new List<EntityMonster>();
		}
		List<EntityMonster> list = new List<EntityMonster>();
		foreach (EntityMonster item in base.Player.SceneInstance.Entities.Values.OfType<EntityMonster>())
		{
			if (item.IsAlive && TryResolveStageFromEvent(item.GetStageId(), base.Player.Data.WorldLevel, out StageConfigExcel stage) && stage != null && stage.StageID == stageId)
			{
				list.Add(item);
			}
		}
		if (list.Count > 0)
		{
			return list;
		}
		foreach (EntityMonster item2 in base.Player.SceneInstance.Entities.Values.OfType<EntityMonster>())
		{
			if (item2.IsAlive && TryResolveStageFromEvent(item2.Info.EventID, base.Player.Data.WorldLevel, out StageConfigExcel stage2) && stage2 != null && stage2.StageID == stageId)
			{
				list.Add(item2);
			}
		}
		return list;
	}

	private static bool TryResolveStageFromEvent(int eventId, int worldLevel, out StageConfigExcel? stage)
	{
		stage = null;
		if (eventId <= 0)
		{
			return false;
		}
		if (GameData.PlaneEventData.TryGetValue(eventId * 10 + worldLevel, out PlaneEventExcel value) && GameData.StageConfigData.TryGetValue(value.StageID, out stage))
		{
			return true;
		}
		if (GameData.PlaneEventData.TryGetValue(eventId, out PlaneEventExcel value2) && GameData.StageConfigData.TryGetValue(value2.StageID, out stage))
		{
			return true;
		}
		if (GameData.StageConfigData.TryGetValue(eventId * 10 + worldLevel, out stage))
		{
			return true;
		}
		if (GameData.StageConfigData.TryGetValue(eventId, out stage))
		{
			return true;
		}
		stage = null;
		return false;
	}
}
