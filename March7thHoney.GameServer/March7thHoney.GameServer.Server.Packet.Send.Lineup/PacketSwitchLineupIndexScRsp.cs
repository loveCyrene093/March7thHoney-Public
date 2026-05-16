using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Lineup;

public class PacketSwitchLineupIndexScRsp : BasePacket
{
	public PacketSwitchLineupIndexScRsp(uint index)
		: base(772)
	{
		SwitchLineupIndexScRsp data = new SwitchLineupIndexScRsp
		{
			Index = index
		};
		SetData(data);
	}
}
