using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.PlayerBoard;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.PlayerBoard;

[Opcode(2826)]
public class HandlerSetSignatureCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SetSignatureCsReq setSignatureCsReq = SetSignatureCsReq.Parser.ParseFrom(data);
		connection.Player.Data.Signature = setSignatureCsReq.Signature;
		await connection.SendPacket(new PacketSetSignatureScRsp(setSignatureCsReq.Signature));
	}
}
