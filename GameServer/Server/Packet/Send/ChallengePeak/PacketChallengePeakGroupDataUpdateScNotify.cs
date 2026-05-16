using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.ChallengePeak;

public class PacketChallengePeakGroupDataUpdateScNotify : BasePacket
{
	public PacketChallengePeakGroupDataUpdateScNotify(ChallengePeakGroup info)
		: base(8901)
	{
		ChallengePeakGroupDataUpdateScNotify data = new ChallengePeakGroupDataUpdateScNotify
		{
			ChallengePeakGroup = info
		};
		SetData(data);
	}
}
