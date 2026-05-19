using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;

namespace March7thHoney.GameServer.Server.Packet.Send.TrainParty;

public class PacketTrainPartyMoveScNotify : BasePacket
{
	public PacketTrainPartyMoveScNotify(PlayerInstance player)
		: base(8014)
	{
		SetData(player.TrainPartyManager.BuildMoveNotify());
	}
}
