using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.TrainParty;

public class PacketTrainPartyBuildRoomScNotify : BasePacket
{
	public PacketTrainPartyBuildRoomScNotify(PlayerInstance player)
		: base(8054)
	{
		SetData(new TrainPartyBuildRoomScNotify
		{
			MBIEMBJMJJN = player.TrainPartyManager.ToPartyInfo()
		});
	}
}
