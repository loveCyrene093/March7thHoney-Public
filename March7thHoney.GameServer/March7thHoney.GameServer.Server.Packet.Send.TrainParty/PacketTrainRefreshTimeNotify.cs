using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.TrainParty;

public class PacketTrainRefreshTimeNotify : BasePacket
{
	public PacketTrainRefreshTimeNotify(ulong refreshTime)
		: base(3714)
	{
		SetData(new TrainRefreshTimeNotify
		{
			TrainRefreshTime = refreshTime
		});
	}
}
