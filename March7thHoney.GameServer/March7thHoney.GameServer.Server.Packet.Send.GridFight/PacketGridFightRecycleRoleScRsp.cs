using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.GridFight;

public class PacketGridFightRecycleRoleScRsp : BasePacket
{
	public PacketGridFightRecycleRoleScRsp()
		: base(8642)
	{
		SetData(new GridFightRecycleRoleScRsp());
	}
}
