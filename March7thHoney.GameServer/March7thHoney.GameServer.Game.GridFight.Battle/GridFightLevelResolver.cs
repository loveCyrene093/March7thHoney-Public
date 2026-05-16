using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data;
using March7thHoney.Data.Excel;

namespace March7thHoney.GameServer.Game.GridFight.Battle;

public static class GridFightLevelResolver
{
	public const uint UnifiedStageId = 70000001u;

	public static GridFightLevelEncounter Resolve(GridFightInstance inst)
	{
		uint penaltyBonusRuleId = ResolvePenaltyRuleId(inst);
		(uint EliteGroup, List<GridFightMonsterSpec> Monsters) tuple = ResolveWave(inst);
		uint item = tuple.EliteGroup;
		List<GridFightMonsterSpec> item2 = tuple.Monsters;
		List<uint> bindingBuffs = ResolveBindingBuffs();
		List<uint> battleEvents = ResolveBattleEvents();
		List<uint> traitIds = ResolveTraitIds(inst);
		return new GridFightLevelEncounter(70000001u, penaltyBonusRuleId, item, item2, bindingBuffs, battleEvents, traitIds);
	}

	private static uint ResolvePenaltyRuleId(GridFightInstance inst)
	{
		GridFightStageRouteExcel gridFightStageRouteExcel = GameData.GridFightStageRouteData.Values.SelectMany((Dictionary<uint, GridFightStageRouteExcel> d) => d.Values).FirstOrDefault((GridFightStageRouteExcel r) => r.ChapterID == inst.CurrentChapterId && r.SectionID == inst.SectionId);
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
		return (EliteGroup: 1816u, Monsters: new List<GridFightMonsterSpec>
		{
			new GridFightMonsterSpec(201101005u, 1u, new List<uint> { 102u, 204u }),
			new GridFightMonsterSpec(800104004u, 1u, new List<uint> { 203u }),
			new GridFightMonsterSpec(800104004u, 1u, new List<uint> { 199u })
		});
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
