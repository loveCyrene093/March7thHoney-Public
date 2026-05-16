using System.Collections.Generic;
using March7thHoney.GameServer.Game.Battle;

namespace March7thHoney.GameServer.Game.Task.AvatarTask;

public record AbilityLevelResult(BattleInstance? Instance = null, List<HitMonsterInstance>? BattleInfos = null);
