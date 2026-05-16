using System.Collections.Generic;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.Battle;

public record SkillResultData(Retcode RetCode, BattleInstance? Instance = null, List<HitMonsterInstance>? TriggerBattleInfos = null);
