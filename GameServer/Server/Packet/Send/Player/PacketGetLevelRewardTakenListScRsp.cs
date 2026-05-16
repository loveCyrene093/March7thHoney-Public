using System.Linq;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Player;

public class PacketGetLevelRewardTakenListScRsp : BasePacket
{
	public PacketGetLevelRewardTakenListScRsp(PlayerInstance player)
		: base(44)
	{
		GetLevelRewardTakenListScRsp data = new GetLevelRewardTakenListScRsp
		{
			LevelRewardTakenList = { player.Data.TakenLevelReward.Select((int x) => (uint)x) }
		};
		SetData(data);
	}
}
