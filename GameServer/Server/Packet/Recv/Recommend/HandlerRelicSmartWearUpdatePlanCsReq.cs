using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Recommend;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Recommend;

[Opcode(8265)]
public class HandlerRelicSmartWearUpdatePlanCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		RelicSmartWearUpdatePlanCsReq relicSmartWearUpdatePlanCsReq = RelicSmartWearUpdatePlanCsReq.Parser.ParseFrom(data);
		connection.Player.AvatarManager.UpdateRelicPlan(relicSmartWearUpdatePlanCsReq.RelicPlan);
		await connection.SendPacket(new PacketRelicSmartWearUpdatePlanScRsp(relicSmartWearUpdatePlanCsReq.RelicPlan));
	}
}
