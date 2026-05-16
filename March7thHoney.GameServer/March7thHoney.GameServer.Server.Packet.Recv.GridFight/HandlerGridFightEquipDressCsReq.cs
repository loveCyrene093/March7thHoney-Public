using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.GridFight;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.GridFight;

[Opcode(8758)]
public class HandlerGridFightEquipDressCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GridFightEquipDressCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketJNNNJBAOCOB());
		await connection.SendPacket(new PacketGridFightSyncUpdateResultScNotify(connection.Player, 8));
	}
}
