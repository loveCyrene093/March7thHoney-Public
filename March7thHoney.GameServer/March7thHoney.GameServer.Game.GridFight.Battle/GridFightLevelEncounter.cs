using System.Collections.Generic;

namespace March7thHoney.GameServer.Game.GridFight.Battle;

public record GridFightLevelEncounter(uint StageId, uint PenaltyBonusRuleId, uint EliteGroupId, List<GridFightMonsterSpec> Monsters, List<uint> BindingBuffs, List<uint> BattleEvents, List<uint> TraitIds);
