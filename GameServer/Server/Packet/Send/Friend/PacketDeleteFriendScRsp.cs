using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Friend;

public class PacketDeleteFriendScRsp : BasePacket
{
	public PacketDeleteFriendScRsp()
		: base(2937)
	{
		DeleteFriendScRsp data = new DeleteFriendScRsp();
		SetData(data);
	}

	public PacketDeleteFriendScRsp(uint uid)
		: base(2937)
	{
		DeleteFriendScRsp data = new DeleteFriendScRsp
		{
			Uid = uid
		};
		SetData(data);
	}
}
