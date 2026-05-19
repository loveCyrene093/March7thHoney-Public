using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Data.Freesr;
using March7thHoney.Database;
using March7thHoney.Database.Calyx;
using March7thHoney.Database.Lineup;
using March7thHoney.GameServer.Game.Battle;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Game.Scene;
using March7thHoney.GameServer.Plugin.Event;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Calyx;

public class CalyxOverrideManager : BasePlayerManager
{
	private CalyxOverrideData? _data;

	private static Dictionary<int, ChallengeConfigExcel>? _stageToChallenge;

	public CalyxOverrideData Data
	{
		get
		{
			CalyxOverrideData calyxOverrideData = _data;
			if (calyxOverrideData == null)
			{
				CalyxOverrideData obj = new CalyxOverrideData
				{
					Uid = base.Player.Uid
				};
				CalyxOverrideData calyxOverrideData2 = obj;
				_data = obj;
				calyxOverrideData = calyxOverrideData2;
			}
			return calyxOverrideData;
		}
	}

	public bool IsActive
	{
		get
		{
			CalyxOverrideData data = Data;
			if (data != null && data.IsActive)
			{
				return data.CachedJson != null;
			}
			return false;
		}
	}

	public CalyxOverrideManager(PlayerInstance player)
		: base(player)
	{
	}

	public void AttachData(CalyxOverrideData data)
	{
		_data = data;
	}

	public void Disable()
	{
		Data.IsActive = false;
		DatabaseHelper.ToSaveUidList.SafeAdd(base.Player.Uid);
	}

	public void Enable()
	{
		Data.IsActive = true;
		Data.LoadedAtUnix = Extensions.GetUnixSec();
		DatabaseHelper.ToSaveUidList.SafeAdd(base.Player.Uid);
	}

	public async ValueTask<BattleInstance?> BuildOverrideBattle(int cocoonId, int wave, int worldLevel)
	{
		FreesrCalyxData cachedJson = Data.CachedJson;
		FreesrBattleConfig freesrBattleConfig = cachedJson?.BattleConfig;
		if (cachedJson == null || freesrBattleConfig == null)
		{
			return null;
		}
		StageConfigExcel value = null;
		if (freesrBattleConfig.StageId > 0)
		{
			GameData.StageConfigData.TryGetValue(freesrBattleConfig.StageId, out value);
		}
		if (value == null && GameData.CocoonConfigData.TryGetValue(cocoonId * 100 + worldLevel, out CocoonConfigExcel value2))
		{
			GameData.StageConfigData.TryGetValue(value2.StageIDList.RandomElement(), out value);
		}
		if (value == null)
		{
			return null;
		}
		List<StageMonsterList> list = BuildMonsterList(freesrBattleConfig.Monsters);
		StageConfigExcel item = new StageConfigExcel
		{
			StageID = value.StageID,
			StageName = value.StageName,
			TrialAvatarList = value.TrialAvatarList,
			MonsterList = (list ?? value.MonsterList)
		};
		LineupInfo curLineup = base.Player.LineupManager.GetCurLineup();
		BattleInstance battle = new BattleInstance(base.Player, curLineup, new List<StageConfigExcel>(1) { item })
		{
			StaminaCost = 0,
			WorldLevel = ((worldLevel > 0) ? worldLevel : base.Player.Data.WorldLevel),
			CocoonWave = Math.Max(wave, 1),
			MappingInfoId = 0,
			RoundLimit = ((freesrBattleConfig.CycleCount > 0) ? freesrBattleConfig.CycleCount : 0),
			CustomLevel = ResolveUniformLevel(freesrBattleConfig.Monsters),
			CalyxOverride = new CalyxOverrideContext(cachedJson)
		};
		List<AvatarSceneInfo> avatarInfo = curLineup.BaseAvatars.Select((LineupAvatarInfo lineupAvatarInfo) => base.Player.SceneInstance.AvatarInfo.Values.FirstOrDefault((AvatarSceneInfo x) => x.AvatarInfo.AvatarId == lineupAvatarInfo.BaseAvatarId)).OfType<AvatarSceneInfo>().ToList();
		battle.AvatarInfo = avatarInfo;
		ApplyChallengeStageRules(battle, (freesrBattleConfig.StageId > 0) ? freesrBattleConfig.StageId : value.StageID);
		base.Player.BattleInstance = battle;
		base.Player.QuestManager.OnBattleStart(battle);
		PluginEvent.InvokeOnPlayerEnterBattle(base.Player, battle);
		await ValueTask.CompletedTask;
		return battle;
	}

	private static Dictionary<int, ChallengeConfigExcel> GetStageToChallengeIndex()
	{
		if (_stageToChallenge != null)
		{
			return _stageToChallenge;
		}
		Dictionary<int, ChallengeConfigExcel> idx = new Dictionary<int, ChallengeConfigExcel>();
		foreach (ChallengeConfigExcel value3 in GameData.ChallengeConfigData.Values)
		{
			ChallengeConfigExcel config = value3;
			foreach (List<ChallengeConfigExcel.ChallengeMonsterInfo> value4 in config.ChallengeMonsters1.Values)
			{
				foreach (ChallengeConfigExcel.ChallengeMonsterInfo item in value4)
				{
					Map(item.EventId);
				}
			}
			foreach (List<ChallengeConfigExcel.ChallengeMonsterInfo> value5 in config.ChallengeMonsters2.Values)
			{
				foreach (ChallengeConfigExcel.ChallengeMonsterInfo item2 in value5)
				{
					Map(item2.EventId);
				}
			}
			void Map(int eventId)
			{
				if (eventId > 0)
				{
					idx.TryAdd(eventId, config);
					if (GameData.PlaneEventData.TryGetValue(eventId, out PlaneEventExcel value))
					{
						idx.TryAdd(value.StageID, config);
					}
					for (int i = 1; i <= 6; i++)
					{
						if (GameData.PlaneEventData.TryGetValue(eventId * 10 + i, out PlaneEventExcel value2))
						{
							idx.TryAdd(value2.StageID, config);
						}
					}
				}
			}
		}
		_stageToChallenge = idx;
		return idx;
	}

	private static void ApplyChallengeStageRules(BattleInstance battle, int stageId)
	{
		if (!GetStageToChallengeIndex().TryGetValue(stageId, out ChallengeConfigExcel value))
		{
			return;
		}
		if (value.MazeBuffID > 0)
		{
			battle.Buffs.Add(new MazeBuff(value.MazeBuffID, 1, -1)
			{
				WaveFlag = -1
			});
		}
		if (value.IsStory())
		{
			battle.AddBattleTarget(1, 10003, 0);
			if (value.StoryExcel?.BattleTargetID == null)
			{
				return;
			}
			{
				foreach (int item in value.StoryExcel.BattleTargetID)
				{
					battle.AddBattleTarget(5, item, 0);
				}
				return;
			}
		}
		if (value.IsBoss())
		{
			battle.AddBattleTarget(1, 90004, 0);
			battle.AddBattleTarget(1, 90005, 0);
		}
	}

	private static List<StageMonsterList>? BuildMonsterList(List<List<FreesrMonsterEntry>>? waves)
	{
		if (waves == null || waves.Count == 0)
		{
			return null;
		}
		List<StageMonsterList> list = new List<StageMonsterList>(waves.Count);
		foreach (List<FreesrMonsterEntry> wave in waves)
		{
			List<int> list2 = new List<int>(5);
			foreach (FreesrMonsterEntry item in wave)
			{
				if (item.MonsterId <= 0)
				{
					continue;
				}
				int num = Math.Max(1, item.Amount);
				for (int i = 0; i < num; i++)
				{
					if (list2.Count >= 5)
					{
						break;
					}
					list2.Add(item.MonsterId);
				}
			}
			list.Add(new StageMonsterList
			{
				Monster0 = list2.ElementAtOrDefault(0),
				Monster1 = list2.ElementAtOrDefault(1),
				Monster2 = list2.ElementAtOrDefault(2),
				Monster3 = list2.ElementAtOrDefault(3),
				Monster4 = list2.ElementAtOrDefault(4)
			});
		}
		return list;
	}

	private static int ResolveUniformLevel(List<List<FreesrMonsterEntry>>? waves)
	{
		if (waves == null)
		{
			return 0;
		}
		return waves.SelectMany((List<FreesrMonsterEntry> w) => w).FirstOrDefault((FreesrMonsterEntry m) => m.Level > 0)?.Level ?? 0;
	}
}
