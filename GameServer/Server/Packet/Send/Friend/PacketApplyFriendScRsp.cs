using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Friend;

public class PacketApplyFriendScRsp : BasePacket
{
	public PacketApplyFriendScRsp(Retcode ret, uint uid)
		: base(2998)
	{
		ApplyFriendScRsp data = new ApplyFriendScRsp
		{
			Retcode = (uint)ret,
			Uid = uid
		};
		SetData(data);
	}
}
