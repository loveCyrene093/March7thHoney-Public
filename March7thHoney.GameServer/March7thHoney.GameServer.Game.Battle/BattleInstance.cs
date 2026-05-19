using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database;
using March7thHoney.Database.Avatar;
using March7thHoney.Database.Inventory;
using March7thHoney.Database.Lineup;
using March7thHoney.Database.Tutorial;
using March7thHoney.Enums.Avatar;
using March7thHoney.GameServer.Game.Activity.Activities;
using March7thHoney.GameServer.Game.Calyx;
using March7thHoney.GameServer.Game.GridFight;
using March7thHoney.GameServer.Game.GridFight.Battle;
using March7thHoney.GameServer.Game.Lineup;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Game.Scene;
using March7thHoney.GameServer.Game.Scene.Entity;
using March7thHoney.GameServer.Server.Packet.Send.BattleCollege;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Battle;

public class BattleInstance : BasePlayerManager
{
	public delegate ValueTask OnBattleEndDelegate(BattleInstance battle, PVEBattleResultCsReq req);

	public int BattleId { get; set; }

	public int StaminaCost { get; set; }

	public int WorldLevel { get; set; }

	public int CocoonWave { get; set; }

	public int MappingInfoId { get; set; }

	public int RoundLimit { get; set; }

	public int StageId { get; set; }

	public int EventId { get; set; }

	public int CustomLevel { get; set; }

	public BattleEndStatus BattleEndStatus { get; set; }

	public List<ItemData> MonsterDropItems { get; set; }

	public List<StageConfigExcel> Stages { get; set; }

	public March7thHoney.Database.Lineup.LineupInfo Lineup { get; set; }

	public List<EntityMonster> EntityMonsters { get; set; }

	public List<AvatarSceneInfo> AvatarInfo { get; set; }

	public List<MazeBuff> Buffs { get; set; }

	public BattleRogueMagicInfo? MagicInfo { get; set; }

	public Dictionary<int, BattleEventInstance> BattleEvents { get; set; }

	public Dictionary<int, BattleTargetList> BattleTargets { get; set; }

	public BattleCollegeConfigExcel? CollegeConfigExcel { get; set; }

	public PVEBattleResultCsReq? BattleResult { get; set; }

	public bool IsTournRogue { get; set; }

	public GridFightInstance? GridFightContext { get; set; }

	public CalyxOverrideContext? CalyxOverride { get; set; }

	public event OnBattleEndDelegate? OnBattleEnd;

	public BattleInstance(PlayerInstance player, March7thHoney.Database.Lineup.LineupInfo lineup, List<StageConfigExcel> stages)
	{
		BattleId = ++player.NextBattleId;
		StageId = ((stages.Count > 0) ? stages[0].StageID : 0);
		MonsterDropItems = new List<ItemData>();
		Stages = stages;
		Lineup = lineup;
		EntityMonsters = new List<EntityMonster>();
		AvatarInfo = new List<AvatarSceneInfo>();
		Buffs = new List<MazeBuff>();
		BattleEvents = new Dictionary<int, BattleEventInstance>();
		BattleTargets = new Dictionary<int, BattleTargetList>();
		base._002Ector(player);
	}

	public BattleInstance(PlayerInstance player, March7thHoney.Database.Lineup.LineupInfo lineup, List<EntityMonster> monsters)
		: this(player, lineup, new List<StageConfigExcel>())
	{
		if (player.ActivityManager.TrialActivityInstance != null && player.ActivityManager.TrialActivityInstance.Data.CurTrialStageId != 0)
		{
			TrialActivityInstance trialActivityInstance = player.ActivityManager.TrialActivityInstance;
			GameData.StageConfigData.TryGetValue(trialActivityInstance.Data.CurTrialStageId, out StageConfigExcel value);
			if (value != null)
			{
				Stages.Add(value);
			}
			StageId = Stages[0].StageID;
			return;
		}
		HashSet<int> hashSet = new HashSet<int>();
		foreach (EntityMonster monster in monsters)
		{
			if (TryResolveStageFromEvent(monster.GetStageId(), player.Data.WorldLevel, out StageConfigExcel stage) && stage != null && hashSet.Add(stage.StageID))
			{
				Stages.Add(stage);
			}
		}
		if (Stages.Count == 0)
		{
			foreach (EntityMonster monster2 in monsters)
			{
				if (TryResolveStageFromEvent(monster2.Info.EventID, player.Data.WorldLevel, out StageConfigExcel stage2) && stage2 != null && hashSet.Add(stage2.StageID))
				{
					Stages.Add(stage2);
				}
			}
		}
		EntityMonsters = monsters;
		if (Stages.Count > 0)
		{
			StageId = Stages[0].StageID;
		}
	}

	public async ValueTask TriggerOnBattleEnd()
	{
		if (this.OnBattleEnd != null)
		{
			await this.OnBattleEnd(this, BattleResult);
		}
	}

	public ItemList GetDropItemList()
	{
		if (BattleEndStatus != BattleEndStatus.BattleEndWin)
		{
			return new ItemList();
		}
		ItemList list = new ItemList();
		foreach (ItemData monsterDropItem in MonsterDropItems)
		{
			list.ItemList_.Add(monsterDropItem.ToProto());
		}
		System.Threading.Tasks.Task.Run(async delegate
		{
			foreach (ItemData item in await base.Player.InventoryManager.HandleMappingInfo(MappingInfoId, WorldLevel))
			{
				list.ItemList_.Add(item.ToProto());
			}
		}).Wait();
		if (CollegeConfigExcel != null)
		{
			BattleCollegeData? battleCollegeData = base.Player.BattleCollegeData;
			if (battleCollegeData != null && !battleCollegeData.FinishedCollegeIdList.Contains(CollegeConfigExcel.ID))
			{
				base.Player.BattleCollegeData.FinishedCollegeIdList.Add(CollegeConfigExcel.ID);
				System.Threading.Tasks.Task.Run(async delegate
				{
					await base.Player.SendPacket(new PacketBattleCollegeDataChangeScNotify(base.Player));
					foreach (ItemData item2 in await base.Player.InventoryManager.HandleReward(CollegeConfigExcel.RewardID))
					{
						list.ItemList_.Add(item2.ToProto());
					}
				}).Wait();
				return list;
			}
		}
		return list;
	}

	public void AddBattleTarget(int key, int targetId, int progress, int totalProgress = 0)
	{
		if (!BattleTargets.TryGetValue(key, out BattleTargetList value))
		{
			value = new BattleTargetList();
			BattleTargets.Add(key, value);
		}
		BattleTarget item = new BattleTarget
		{
			Id = (uint)targetId,
			Progress = (uint)progress,
			TotalProgress = (uint)totalProgress
		};
		value.BattleTargetList_.Add(item);
	}

	public List<AvatarLineupData> GetBattleAvatars()
	{
		List<int> list = GameData.StageConfigData[StageId].TrialAvatarList.ToList();
		BattleCollegeConfigExcel collegeConfigExcel = CollegeConfigExcel;
		if (collegeConfigExcel != null)
		{
			List<int> trialAvatarList = collegeConfigExcel.TrialAvatarList;
			if (trialAvatarList != null && trialAvatarList.Count > 0)
			{
				list = CollegeConfigExcel.TrialAvatarList.ToList();
			}
		}
		if (list.Count > 0)
		{
			List<int> source = list.ToList();
			if (base.Player.Data.CurrentGender == Gender.Man)
			{
				foreach (int item in source.Where(delegate(int num)
				{
					SpecialAvatarExcel value;
					bool flag = GameData.SpecialAvatarData.TryGetValue(num * 10, out value);
					if (flag)
					{
						bool flag2;
						switch (value.AvatarID)
						{
						case 8002:
						case 8004:
						case 8006:
							flag2 = true;
							break;
						default:
							flag2 = false;
							break;
						}
						flag = flag2;
					}
					return flag;
				}))
				{
					list.Remove(item);
				}
			}
			else
			{
				foreach (int item2 in source.Where(delegate(int num)
				{
					SpecialAvatarExcel value;
					bool flag = GameData.SpecialAvatarData.TryGetValue(num * 10, out value);
					if (flag)
					{
						bool flag2;
						switch (value.AvatarID)
						{
						case 8001:
						case 8003:
						case 8005:
							flag2 = true;
							break;
						default:
							flag2 = false;
							break;
						}
						flag = flag2;
					}
					return flag;
				}))
				{
					list.Remove(item2);
				}
			}
		}
		if (list.Count > 0)
		{
			List<AvatarLineupData> list2 = new List<AvatarLineupData>();
			{
				foreach (int item3 in list)
				{
					SpecialAvatarInfo trialAvatar = base.Player.AvatarManager.GetTrialAvatar(item3);
					if (trialAvatar != null)
					{
						trialAvatar.CheckLevel(base.Player.Data.WorldLevel);
						list2.Add(new AvatarLineupData(trialAvatar, AvatarType.AvatarTrialType));
						continue;
					}
					FormalAvatarInfo formalAvatar = base.Player.AvatarManager.GetFormalAvatar(item3);
					if (formalAvatar != null)
					{
						list2.Add(new AvatarLineupData(formalAvatar, AvatarType.AvatarFormalType));
					}
				}
				return list2;
			}
		}
		List<AvatarLineupData> list3 = new List<AvatarLineupData>();
		foreach (LineupAvatarInfo avatar in Lineup.BaseAvatars)
		{
			BaseAvatarInfo baseAvatarInfo = null;
			AvatarType avatarType = AvatarType.AvatarFormalType;
			if (avatar.AssistUid != 0)
			{
				AvatarData instance = DatabaseHelper.Instance.GetInstance<AvatarData>(avatar.AssistUid);
				if (instance != null)
				{
					baseAvatarInfo = instance.FormalAvatars.Find((FormalAvatarInfo item) => item.BaseAvatarId == avatar.BaseAvatarId);
					avatarType = AvatarType.AvatarAssistType;
				}
			}
			else if (avatar.SpecialAvatarId != 0)
			{
				SpecialAvatarInfo trialAvatar2 = base.Player.AvatarManager.GetTrialAvatar(avatar.SpecialAvatarId);
				if (trialAvatar2 != null)
				{
					trialAvatar2.CheckLevel(base.Player.Data.WorldLevel);
					baseAvatarInfo = trialAvatar2;
					avatarType = AvatarType.AvatarTrialType;
				}
			}
			else
			{
				baseAvatarInfo = base.Player.AvatarManager.GetFormalAvatar(avatar.BaseAvatarId);
			}
			if (baseAvatarInfo != null)
			{
				list3.Add(new AvatarLineupData(baseAvatarInfo, avatarType));
			}
		}
		return list3;
	}

	public SceneBattleInfo ToProto()
	{
		SceneBattleInfo sceneBattleInfo = new SceneBattleInfo
		{
			BattleId = (uint)BattleId,
			WorldLevel = (uint)WorldLevel,
			RoundsLimit = (uint)RoundLimit,
			StageId = (uint)StageId,
			LogicRandomSeed = (uint)Random.Shared.Next()
		};
		if (MagicInfo != null)
		{
			sceneBattleInfo.BattleRogueMagicInfo = MagicInfo;
		}
		foreach (List<SceneMonsterWave> item in Stages.Select((StageConfigExcel wave) => wave.ToProto()))
		{
			if (CustomLevel > 0)
			{
				foreach (SceneMonsterWave item2 in item)
				{
					item2.MonsterParam.Level = (uint)CustomLevel;
				}
			}
			sceneBattleInfo.MonsterWaveList.AddRange(item);
		}
		if (base.Player.BattleManager.NextBattleMonsterIds.Count > 0)
		{
			List<int> nextBattleMonsterIds = base.Player.BattleManager.NextBattleMonsterIds;
			for (int num = 0; num < (nextBattleMonsterIds.Count - 1) / 5 + 1; num++)
			{
				int count = Math.Min(5, nextBattleMonsterIds.Count - num * 5);
				List<int> range = nextBattleMonsterIds.GetRange(num * 5, count);
				sceneBattleInfo.MonsterWaveList.Add(new SceneMonsterWave
				{
					BattleStageId = (uint)(Stages.FirstOrDefault()?.StageID ?? 0),
					BattleWaveId = (uint)(sceneBattleInfo.MonsterWaveList.Count + 1),
					MonsterParam = new SceneMonsterWaveParam(),
					MonsterList = { range.Select((int x) => new SceneMonster
					{
						MonsterId = (uint)x
					}) }
				});
			}
		}
		List<AvatarLineupData> avatars;
		if (GridFightContext != null)
		{
			avatars = GridFightBattleProtoBuilder.HandleProto(this, GridFightContext, sceneBattleInfo);
		}
		else
		{
			avatars = GetBattleAvatars();
			foreach (AvatarLineupData item3 in avatars)
			{
				sceneBattleInfo.BattleAvatarList.Add(item3.AvatarInfo.ToBattleProto(new PlayerDataCollection(base.Player.Data, base.Player.InventoryManager.Data, Lineup), item3.AvatarType));
			}
		}
		System.Threading.Tasks.Task.Run(async delegate
		{
			foreach (EntityMonster entityMonster in EntityMonsters)
			{
				await entityMonster.ApplyBuff(this);
			}
			foreach (AvatarSceneInfo avatar in AvatarInfo)
			{
				if (avatars.Select((AvatarLineupData x) => x.AvatarInfo).FirstOrDefault((BaseAvatarInfo x) => x.BaseAvatarId == avatar.AvatarInfo.BaseAvatarId) != null)
				{
					await avatar.ApplyBuff(this);
				}
			}
		}).Wait();
		foreach (MazeBuff buff in Buffs.Clone())
		{
			if (Enum.IsDefined(typeof(DamageTypeEnum), buff.BuffID))
			{
				Buffs.RemoveAll((MazeBuff x) => x.BuffID == buff.BuffID && x.DynamicValues.Count == 0);
			}
		}
		foreach (BattleEventInstance value2 in BattleEvents.Values)
		{
			sceneBattleInfo.BattleEvent.Add(value2.ToProto());
		}
		for (int num2 = 1; num2 <= 5; num2++)
		{
			BattleTargetList battleTargetList = new BattleTargetList();
			if (BattleTargets.TryGetValue(num2, out BattleTargetList value))
			{
				battleTargetList.BattleTargetList_.AddRange(value.BattleTargetList_);
			}
			sceneBattleInfo.BattleTargetInfo.Add((uint)num2, battleTargetList);
		}
		foreach (AvatarGlobalBuffConfigExcel value3 in GameData.AvatarGlobalBuffConfigData.Values)
		{
			if (base.Player.AvatarManager.GetFormalAvatar(value3.AvatarID) != null)
			{
				Buffs.Add(new MazeBuff(value3.MazeBuffID, 1, -1)
				{
					WaveFlag = -1
				});
			}
		}
		foreach (MazeBuff buff2 in Buffs)
		{
			if (buff2.WaveFlag.HasValue)
			{
				continue;
			}
			List<MazeBuff> list = Buffs.FindAll((MazeBuff x) => x.BuffID == buff2.BuffID);
			if (list.Count < 2)
			{
				continue;
			}
			int num3 = 0;
			foreach (MazeBuff item4 in list)
			{
				item4.WaveFlag = (int)Math.Pow(2.0, num3);
				num3++;
			}
		}
		CalyxOverride?.Apply(this, sceneBattleInfo);
		sceneBattleInfo.BuffList.AddRange(Buffs.Select((MazeBuff mazeBuff) => mazeBuff.ToProto(this)));
		return sceneBattleInfo;
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
		if (GameData.StageConfigData.TryGetValue(eventId, out stage))
		{
			return true;
		}
		PlaneEventExcel planeEventExcel = GameData.PlaneEventData.Values.FirstOrDefault((PlaneEventExcel x) => x.EventID == eventId);
		if (planeEventExcel != null && GameData.StageConfigData.TryGetValue(planeEventExcel.StageID, out stage))
		{
			return true;
		}
		return false;
	}
}
