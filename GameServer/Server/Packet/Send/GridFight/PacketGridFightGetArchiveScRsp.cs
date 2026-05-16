using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.GridFight;

public class PacketGridFightGetArchiveScRsp : BasePacket
{
	public PacketGridFightGetArchiveScRsp()
		: base(8455)
	{
		SetData(new GridFightGetArchiveScRsp());
	}
}
