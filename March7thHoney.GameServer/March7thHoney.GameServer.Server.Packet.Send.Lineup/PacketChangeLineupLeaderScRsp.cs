using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Lineup;

public class PacketChangeLineupLeaderScRsp : BasePacket
{
	public PacketChangeLineupLeaderScRsp(uint slot)
		: base(704)
	{
		ChangeLineupLeaderScRsp data = new ChangeLineupLeaderScRsp
		{
			Slot = slot
		};
		SetData(data);
	}

	public PacketChangeLineupLeaderScRsp()
		: base(704)
	{
		ChangeLineupLeaderScRsp data = new ChangeLineupLeaderScRsp
		{
			Retcode = 1u
		};
		SetData(data);
	}
}
