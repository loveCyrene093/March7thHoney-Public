using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.TrainParty;

public class PacketTrainWorldIdChangeScNotify : BasePacket
{
	public PacketTrainWorldIdChangeScNotify(uint worldId)
		: base(1450)
	{
		SetData(new TrainWorldIdChangeScNotify
		{
			LLOLOEHPFHA = worldId
		});
	}
}
