using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Lineup;

public class PacketExtraLineupDestroyNotify : BasePacket
{
	public PacketExtraLineupDestroyNotify(ExtraLineupType type)
		: base(789)
	{
		ExtraLineupDestroyNotify data = new ExtraLineupDestroyNotify
		{
			ExtraLineupType = type
		};
		SetData(data);
	}
}
