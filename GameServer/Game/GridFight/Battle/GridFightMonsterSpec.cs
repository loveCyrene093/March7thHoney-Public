using System.Collections.Generic;

namespace March7thHoney.GameServer.Game.GridFight.Battle;

public record GridFightMonsterSpec(uint MonsterId, uint RoleStar, List<uint> DropItemIds);
