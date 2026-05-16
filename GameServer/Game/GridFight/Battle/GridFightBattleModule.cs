using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Lineup;
using March7thHoney.GameServer.Game.Battle;
using March7thHoney.GameServer.Game.Player;

namespace March7thHoney.GameServer.Game.GridFight.Battle;

public static class GridFightBattleModule
{
	public static BattleInstance? StartBattle(PlayerInstance player, GridFightInstance gridFightInstance)
	{
		if (player.BattleInstance != null)
		{
			return player.BattleInstance;
		}
		if (!GameData.StageConfigData.TryGetValue(70000001, out StageConfigExcel value))
		{
			return null;
		}
		List<int> first = gridFightInstance.BuildForegroundAvatarIds();
		List<int> second = gridFightInstance.BuildBackgroundAvatarIds();
		LineupInfo lineup = new LineupInfo
		{
			LineupType = 12,
			BaseAvatars = (from id in first.Concat(second)
				select new LineupAvatarInfo
				{
					BaseAvatarId = id
				}).ToList(),
			AvatarData = player.AvatarManager?.AvatarData
		};
		int num = 1;
		List<StageConfigExcel> list = new List<StageConfigExcel>(num);
		CollectionsMarshal.SetCount(list, num);
		CollectionsMarshal.AsSpan(list)[0] = value;
		return player.BattleInstance = new BattleInstance(player, lineup, list)
		{
			WorldLevel = player.Data.WorldLevel,
			GridFightContext = gridFightInstance
		};
	}
}
