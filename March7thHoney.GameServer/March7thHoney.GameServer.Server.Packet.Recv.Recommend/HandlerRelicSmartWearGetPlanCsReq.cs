using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Recommend;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Recommend;

[Opcode(8251)]
public class HandlerRelicSmartWearGetPlanCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		RelicSmartWearGetPlanCsReq relicSmartWearGetPlanCsReq = RelicSmartWearGetPlanCsReq.Parser.ParseFrom(data);
		List<RelicSmartWearPlan> relicPlan = connection.Player.AvatarManager.GetRelicPlan((int)relicSmartWearGetPlanCsReq.AvatarId);
		await connection.SendPacket(new PacketRelicSmartWearGetPlanScRsp(relicSmartWearGetPlanCsReq.AvatarId, relicPlan));
	}
}
