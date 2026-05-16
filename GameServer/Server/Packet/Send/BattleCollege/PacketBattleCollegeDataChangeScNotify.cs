using System.Collections.Generic;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.BattleCollege;

public class PacketBattleCollegeDataChangeScNotify : BasePacket
{
	public PacketBattleCollegeDataChangeScNotify(PlayerInstance player)
		: base(5794)
	{
		SyncBattleCollegeDataChangeScNotify syncBattleCollegeDataChangeScNotify = new SyncBattleCollegeDataChangeScNotify();
		foreach (int item in player.BattleCollegeData?.FinishedCollegeIdList ?? new List<int>())
		{
			syncBattleCollegeDataChangeScNotify.FinishedCollegeIdList.Add((uint)item);
		}
		SetData(syncBattleCollegeDataChangeScNotify);
	}
}
