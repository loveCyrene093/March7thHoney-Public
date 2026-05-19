using System;
using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Enums.GridFight;

namespace March7thHoney.GameServer.Game.GridFight.Battle;

public static class GridFightLevelResolver
{
	public const uint UnifiedStageId = 70000001u;

	public static GridFightLevelEncounter Resolve(GridFightInstance inst)
	{
		uint stageId = ResolveRoute(inst)?.StageID ?? 70000001;
		uint penaltyBonusRuleId = ResolvePenaltyRuleId(inst);
		(uint EliteGroup, List<GridFightMonsterSpec> Monsters) tuple = ResolveWave(inst);
		uint item = tuple.EliteGroup;
		List<GridFightMonsterSpec> item2 = tuple.Monsters;
		List<uint> bindingBuffs = ResolveBindingBuffs();
		List<uint> battleEvents = ResolveBattleEvents();
		List<uint> traitIds = ResolveTraitIds(inst);
		return new GridFightLevelEncounter(stageId, penaltyBonusRuleId, item, item2, bindingBuffs, battleEvents, traitIds);
	}

	private static GridFightStageRouteExcel? ResolveRoute(GridFightInstance inst)
	{
		return GameData.GridFightStageRouteData.Values.SelectMany((Dictionary<uint, GridFightStageRouteExcel> d) => d.Values).FirstOrDefault((GridFightStageRouteExcel r) => r.ChapterID == inst.CurrentChapterId && r.SectionID == inst.SectionId);
	}

	private static uint ResolvePenaltyRuleId(GridFightInstance inst)
	{
		GridFightStageRouteExcel gridFightStageRouteExcel = ResolveRoute(inst);
		if (gridFightStageRouteExcel == null)
		{
			return 90303u;
		}
		if (gridFightStageRouteExcel.PenaltyBonusRuleIDList.Count > 0)
		{
			return gridFightStageRouteExcel.PenaltyBonusRuleIDList[0];
		}
		if (GameData.GridFightNodeTemplateData.TryGetValue(gridFightStageRouteExcel.NodeTemplateID, out GridFightNodeTemplateExcel value) && value.PenaltyBonusRuleID != 0)
		{
			return value.PenaltyBonusRuleID;
		}
		return 90303u;
	}

	private static (uint EliteGroup, List<GridFightMonsterSpec> Monsters) ResolveWave(GridFightInstance inst)
	{
		GridFightStageRouteExcel gridFightStageRouteExcel = ResolveRoute(inst);
		List<GridFightMonsterExcel> list = ResolveCamp(inst)?.Monsters ?? new List<GridFightMonsterExcel>();
		if (list.Count == 0)
		{
			return (EliteGroup: 1816u, Monsters: new List<GridFightMonsterSpec>
			{
				new GridFightMonsterSpec(201101005u, 1u, new List<uint> { 102u }),
				new GridFightMonsterSpec(800104004u, 1u, new List<uint> { 199u }),
				new GridFightMonsterSpec(800104004u, 1u, new List<uint> { 203u })
			});
		}
		Random shared = Random.Shared;
		List<GridFightMonsterSpec> list2 = new List<GridFightMonsterSpec>();
		GridFightNodeTypeEnum? gridFightNodeTypeEnum = gridFightStageRouteExcel?.NodeType;
		if (gridFightNodeTypeEnum == GridFightNodeTypeEnum.Monster)
		{
			List<GridFightMonsterExcel> list3 = list.Where((GridFightMonsterExcel m) => m.MonsterTier <= 2).ToList();
			if (list3.Count == 0)
			{
				list3 = list.ToList();
			}
			for (int num = 0; num < 5; num++)
			{
				if (list3.Count <= 0)
				{
					break;
				}
				GridFightMonsterExcel gridFightMonsterExcel = list3[shared.Next(list3.Count)];
				list2.Add(new GridFightMonsterSpec(gridFightMonsterExcel.MonsterID, 1u, new List<uint>()));
			}
			return (EliteGroup: 1816u, Monsters: list2);
		}
		if (gridFightNodeTypeEnum == GridFightNodeTypeEnum.CampMonster || gridFightNodeTypeEnum == GridFightNodeTypeEnum.EliteBranch)
		{
			uint[] array = new uint[5] { 3u, 2u, 2u, 2u, 2u };
			foreach (uint tier in array)
			{
				List<GridFightMonsterExcel> list4 = list.Where((GridFightMonsterExcel m) => m.MonsterTier == tier).ToList();
				if (list4.Count == 0)
				{
					list4 = list.Where((GridFightMonsterExcel m) => m.MonsterTier <= 3).ToList();
				}
				if (list4.Count != 0)
				{
					GridFightMonsterExcel gridFightMonsterExcel2 = list4[shared.Next(list4.Count)];
					list2.Add(new GridFightMonsterSpec(gridFightMonsterExcel2.MonsterID, 1u, new List<uint>()));
				}
			}
			if (list2.Count == 0)
			{
				GridFightMonsterExcel gridFightMonsterExcel3 = list[shared.Next(list.Count)];
				list2.Add(new GridFightMonsterSpec(gridFightMonsterExcel3.MonsterID, 1u, new List<uint>()));
			}
			return (EliteGroup: 1817u, Monsters: list2);
		}
		if (gridFightNodeTypeEnum == GridFightNodeTypeEnum.Boss)
		{
			List<GridFightMonsterExcel> list5 = list.Where((GridFightMonsterExcel m) => m.MonsterTier >= 5).ToList();
			if (list5.Count == 0)
			{
				list5 = list.ToList();
			}
			GridFightMonsterExcel gridFightMonsterExcel4 = list5[shared.Next(list5.Count)];
			list2.Add(new GridFightMonsterSpec(gridFightMonsterExcel4.MonsterID, 1u, new List<uint>()));
			return (EliteGroup: 1819u, Monsters: list2);
		}
		List<GridFightMonsterExcel> list6 = list.Where((GridFightMonsterExcel m) => m.MonsterTier <= 2).ToList();
		if (list6.Count == 0)
		{
			list6 = list.ToList();
		}
		for (int num3 = 0; num3 < 3; num3++)
		{
			if (list6.Count <= 0)
			{
				break;
			}
			GridFightMonsterExcel gridFightMonsterExcel5 = list6[shared.Next(list6.Count)];
			list2.Add(new GridFightMonsterSpec(gridFightMonsterExcel5.MonsterID, 1u, new List<uint>()));
		}
		return (EliteGroup: 1816u, Monsters: list2);
	}

	private static GridFightCampExcel? ResolveCamp(GridFightInstance inst)
	{
		foreach (uint sessionCampId in inst.SessionCampIds)
		{
			if (GameData.GridFightCampData.TryGetValue(sessionCampId, out GridFightCampExcel value) && value.Monsters.Count > 0)
			{
				return value;
			}
		}
		return (from c in GameData.GridFightCampData.Values
			where c.Monsters.Count > 0 && (c.SeasonID == 0 || c.SeasonID == inst.Season)
			orderby c.ID
			select c).FirstOrDefault();
	}

	private static List<uint> ResolveBindingBuffs()
	{
		return new List<uint> { 35100001u };
	}

	private static List<uint> ResolveBattleEvents()
	{
		return new List<uint> { 62210u, 11216u, 60014u, 60020u, 60023u, 60024u, 60028u, 60036u };
	}

	private static List<uint> ResolveTraitIds(GridFightInstance inst)
	{
		HashSet<uint> hashSet = new HashSet<uint>();
		foreach (uint item in from uid in inst.UniqueIdByPos.Values
			select inst.RoleByUniqueId.GetValueOrDefault(uid) into r
			where r != 0
			select r)
		{
			if (!GameData.GridFightRoleBasicInfoData.TryGetValue(item, out GridFightRoleBasicInfoExcel value))
			{
				continue;
			}
			foreach (uint trait in value.TraitList)
			{
				hashSet.Add(trait);
			}
		}
		return hashSet.ToList();
	}
}
