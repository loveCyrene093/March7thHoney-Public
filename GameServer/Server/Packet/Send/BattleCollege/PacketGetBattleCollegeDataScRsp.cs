using System.Collections.Generic;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.BattleCollege;

public class PacketGetBattleCollegeDataScRsp : BasePacket
{
	public PacketGetBattleCollegeDataScRsp(PlayerInstance player)
		: base(5710)
	{
		GetBattleCollegeDataScRsp getBattleCollegeDataScRsp = new GetBattleCollegeDataScRsp();
		foreach (int item in player.BattleCollegeData?.FinishedCollegeIdList ?? new List<int>())
		{
			getBattleCollegeDataScRsp.FinishedCollegeIdList.Add((uint)item);
		}
		SetData(getBattleCollegeDataScRsp);
	}
}
