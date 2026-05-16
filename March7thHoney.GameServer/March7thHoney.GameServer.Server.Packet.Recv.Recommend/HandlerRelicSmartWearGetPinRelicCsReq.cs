using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Recommend;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Recommend;

[Opcode(8261)]
public class HandlerRelicSmartWearGetPinRelicCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		RelicSmartWearGetPinRelicCsReq relicSmartWearGetPinRelicCsReq = RelicSmartWearGetPinRelicCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketRelicSmartWearGetPinRelicScRsp(relicSmartWearGetPinRelicCsReq.AvatarId));
	}
}
