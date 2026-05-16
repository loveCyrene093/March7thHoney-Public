using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Friend;

public class PacketDeleteBlacklistScRsp : BasePacket
{
	public PacketDeleteBlacklistScRsp(uint uid)
		: base(2996)
	{
		DeleteBlacklistScRsp data = new DeleteBlacklistScRsp
		{
			Uid = uid
		};
		SetData(data);
	}
}
