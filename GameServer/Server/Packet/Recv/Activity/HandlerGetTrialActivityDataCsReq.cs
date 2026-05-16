using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Activity;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Activity;

[Opcode(2692)]
public class HandlerGetTrialActivityDataCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GetTrialActivityDataCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketGetTrialActivityDataScRsp(connection.Player));
	}
}
