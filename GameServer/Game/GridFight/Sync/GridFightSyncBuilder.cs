using System.Collections.Generic;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.GridFight.Sync;

public static class GridFightSyncBuilder
{
	public static GridFightSyncUpdateResultScNotify Build(PlayerInstance player, IEnumerable<GridFightPosInfo>? updatedPosList = null, int kind = 0, object? extra = null)
	{
		return player.GridFightManager.BuildSyncUpdateNotify(updatedPosList, kind, extra);
	}
}
