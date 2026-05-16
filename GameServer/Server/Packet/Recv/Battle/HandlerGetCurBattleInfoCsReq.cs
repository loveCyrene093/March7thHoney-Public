using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Battle;

namespace March7thHoney.GameServer.Server.Packet.Recv.Battle;

[Opcode(114)]
public class HandlerGetCurBattleInfoCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetCurBattleInfoScRsp());
	}
}
