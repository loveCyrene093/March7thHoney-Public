using System.Collections.Generic;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Avatar;
using March7thHoney.GameServer.Game.Battle;
using March7thHoney.GameServer.Game.Lineup;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.GridFight.Battle;

public static class GridFightBattleProtoBuilder
{
	public static List<AvatarLineupData> HandleProto(BattleInstance battle, GridFightInstance inst, SceneBattleInfo proto)
	{
		GridFightLevelEncounter gridFightLevelEncounter = GridFightLevelResolver.Resolve(inst);
		PlayerInstance player = battle.Player;
		List<AvatarLineupData> list = new List<AvatarLineupData>();
		PlayerDataCollection collection = new PlayerDataCollection(player.Data, player.InventoryManager.Data, battle.Lineup);
		foreach (var item2 in inst.ResolveForegroundRoles())
		{
			uint item = item2.RoleId;
			(BaseAvatarInfo, AvatarType) tuple = ResolveBattleAvatar(player, item);
			var (baseAvatarInfo, _) = tuple;
			if (baseAvatarInfo != null)
			{
				proto.BattleAvatarList.Add(baseAvatarInfo.ToBattleProto(collection, tuple.Item2));
				list.Add(new AvatarLineupData(baseAvatarInfo, tuple.Item2));
			}
		}
		proto.MonsterWaveList.Clear();
		uint enemyDifficultyLevel = inst.GetEnemyDifficultyLevel();
		SceneMonsterWave sceneMonsterWave = new SceneMonsterWave
		{
			BattleStageId = (uint)battle.StageId,
			BattleWaveId = 1u,
			MonsterParam = new SceneMonsterWaveParam
			{
				EliteGroup = gridFightLevelEncounter.EliteGroupId,
				BDCCEFHMFHO = enemyDifficultyLevel
			}
		};
		foreach (GridFightMonsterSpec monster in gridFightLevelEncounter.Monsters)
		{
			SceneMonster sceneMonster = new SceneMonster
			{
				MonsterId = monster.MonsterId,
				ExtraInfo = new MEHAOMGBOMC
				{
					AFCMOOFGBPK = new DLGEGGCHCID
					{
						RoleStar = monster.RoleStar
					}
				}
			};
			foreach (uint dropItemId in monster.DropItemIds)
			{
				sceneMonster.ExtraInfo.AFCMOOFGBPK.PGNMDJIIKJB.Add(new LHPPIAKKFME
				{
					BGKDAMDFFKH = GridFightDropType.HiolcnpoponMkppcdpchie,
					JJFFLMCCCMM = dropItemId,
					Num = 1u
				});
			}
			sceneMonsterWave.MonsterList.Add(sceneMonster);
		}
		proto.MonsterWaveList.Add(sceneMonsterWave);
		foreach (uint bindingBuff in gridFightLevelEncounter.BindingBuffs)
		{
			battle.Buffs.Add(new MazeBuff((int)bindingBuff, 1, -1)
			{
				WaveFlag = -1
			});
		}
		foreach (uint battleEvent in gridFightLevelEncounter.BattleEvents)
		{
			battle.BattleEvents.TryAdd((int)battleEvent, new BattleEventInstance((int)battleEvent, 0, 100000));
		}
		return list;
	}

	internal static (BaseAvatarInfo? Avatar, AvatarType AvatarType) ResolveBattleAvatar(PlayerInstance player, uint roleId)
	{
		if (!GameData.GridFightRoleBasicInfoData.TryGetValue(roleId, out GridFightRoleBasicInfoExcel value))
		{
			return (Avatar: null, AvatarType: AvatarType.AvatarTrialType);
		}
		FormalAvatarInfo formalAvatarInfo = player.AvatarManager?.GetFormalAvatar((int)value.AvatarID);
		if (formalAvatarInfo != null)
		{
			return (Avatar: formalAvatarInfo, AvatarType: AvatarType.AvatarFormalType);
		}
		return (Avatar: player.AvatarManager?.GetTrialAvatarByWorldLevel((int)value.SpecialAvatarID, player.Data.WorldLevel), AvatarType: AvatarType.AvatarTrialType);
	}
}
