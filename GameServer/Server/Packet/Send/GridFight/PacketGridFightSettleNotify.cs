using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;

namespace March7thHoney.GameServer.Server.Packet.Send.GridFight;

public class PacketGridFightSettleNotify : BasePacket
{
	public PacketGridFightSettleNotify(PlayerInstance player)
		: base(8513)
	{
		SetData(player.GridFightManager.BuildSettleNotify());
	}
}
