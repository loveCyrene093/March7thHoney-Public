using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Challenge;

public class PacketChallengeLineupNotify : BasePacket
{
	public PacketChallengeLineupNotify(ExtraLineupType type)
		: base(1701)
	{
		ChallengeLineupNotify data = new ChallengeLineupNotify
		{
			ExtraLineupType = type
		};
		SetData(data);
	}
}
