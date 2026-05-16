using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Recommend;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Recommend;

[Opcode(8264)]
public class HandlerRelicSmartWearDeletePlanCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		RelicSmartWearDeletePlanCsReq relicSmartWearDeletePlanCsReq = RelicSmartWearDeletePlanCsReq.Parser.ParseFrom(data);
		connection.Player.AvatarManager.DeleteRelicPlan((int)relicSmartWearDeletePlanCsReq.UniqueId);
		await connection.SendPacket(new PacketRelicSmartWearDeletePlanScRsp(relicSmartWearDeletePlanCsReq.UniqueId));
	}
}
