using System.Threading.Tasks;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Player;

[Opcode(50)]
public class HandlerForceSyncGameStateFinishCSReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		ForceSyncGameStateFinishCSReq.Parser.ParseFrom(data);
		BasePacket basePacket = new BasePacket(19);
		basePacket.SetData(new ForceSyncGameStateFinishScRsp());
		await connection.SendPacket(basePacket);
	}
}
