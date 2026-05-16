using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.MapRotation;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.MapRotation;

[Opcode(6891)]
public class HandlerEnterMapRotationRegionCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		EnterMapRotationRegionCsReq enterMapRotationRegionCsReq = EnterMapRotationRegionCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketEnterMapRotationRegionScRsp(enterMapRotationRegionCsReq.Motion));
	}
}
