using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.GridFight;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.GridFight;

[Opcode(8541)]
public class HandlerGridFightUpdateEquipTrackPriorityCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GridFightUpdateEquipTrackPriorityCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketGridFightUpdateEquipTrackScRsp());
	}
}
