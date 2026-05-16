using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.BattleCollege;

namespace March7thHoney.GameServer.Server.Packet.Recv.BattleCollege;

[Opcode(5791)]
public class HandlerGetBattleCollegeDataCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetBattleCollegeDataScRsp(connection.Player));
	}
}
