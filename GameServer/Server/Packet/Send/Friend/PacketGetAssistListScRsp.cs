using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Friend;

public class PacketGetAssistListScRsp : BasePacket
{
	public PacketGetAssistListScRsp()
		: base(2965)
	{
		GetAssistListScRsp data = new GetAssistListScRsp();
		SetData(data);
	}
}
