using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.GridFight;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.GridFight;

[Opcode(8439)]
public class HandlerGridFightGetDataCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GridFightGetDataCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketGridFightGetDataScRsp(connection.Player));
	}
}
