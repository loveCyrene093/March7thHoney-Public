using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Friend;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Friend;

[Opcode(2907)]
public class HandlerSetFriendRemarkNameCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SetFriendRemarkNameCsReq setFriendRemarkNameCsReq = SetFriendRemarkNameCsReq.Parser.ParseFrom(data);
		connection.Player.FriendManager.RemarkFriendName((int)setFriendRemarkNameCsReq.Uid, setFriendRemarkNameCsReq.RemarkName);
		await connection.SendPacket(new PacketSetFriendRemarkNameScRsp(setFriendRemarkNameCsReq.Uid, setFriendRemarkNameCsReq.RemarkName));
	}
}
