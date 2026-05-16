using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.GridFight;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.GridFight;

[Opcode(8760)]
public class HandlerGridFightUpdateEquipTrackCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GridFightUpdateEquipTrackCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketGridFightUpdateEquipTrackScRsp());
	}
}
