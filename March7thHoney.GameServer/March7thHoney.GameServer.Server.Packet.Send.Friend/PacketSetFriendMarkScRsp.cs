using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Friend;

public class PacketSetFriendMarkScRsp : BasePacket
{
	public PacketSetFriendMarkScRsp(uint uid, bool isMark)
		: base(2936)
	{
		SetFriendMarkScRsp data = new SetFriendMarkScRsp
		{
			Uid = uid,
			KBNKNAHGPHG = isMark
		};
		SetData(data);
	}
}
