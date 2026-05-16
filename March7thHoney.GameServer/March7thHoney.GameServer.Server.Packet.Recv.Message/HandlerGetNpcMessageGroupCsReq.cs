using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Message;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Message;

[Opcode(2791)]
public class HandlerGetNpcMessageGroupCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GetNpcMessageGroupCsReq getNpcMessageGroupCsReq = GetNpcMessageGroupCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketGetNpcMessageGroupScRsp(getNpcMessageGroupCsReq.ContactIdList, connection.Player));
	}
}
