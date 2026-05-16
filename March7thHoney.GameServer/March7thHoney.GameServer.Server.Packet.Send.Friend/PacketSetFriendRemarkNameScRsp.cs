using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Friend;

public class PacketSetFriendRemarkNameScRsp : BasePacket
{
	public PacketSetFriendRemarkNameScRsp(uint uid, string remarkName)
		: base(2958)
	{
		SetFriendRemarkNameScRsp data = new SetFriendRemarkNameScRsp
		{
			Uid = uid,
			RemarkName = remarkName
		};
		SetData(data);
	}
}
