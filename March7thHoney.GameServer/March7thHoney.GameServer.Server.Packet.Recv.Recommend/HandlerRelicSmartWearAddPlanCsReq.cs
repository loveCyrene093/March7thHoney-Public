using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Recommend;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Recommend;

[Opcode(8252)]
public class HandlerRelicSmartWearAddPlanCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		RelicSmartWearAddPlanCsReq relicSmartWearAddPlanCsReq = RelicSmartWearAddPlanCsReq.Parser.ParseFrom(data);
		RelicSmartWearPlan addPlan = connection.Player.AvatarManager.AddRelicPlan(relicSmartWearAddPlanCsReq.RelicPlan);
		await connection.SendPacket(new PacketRelicSmartWearAddPlanScRsp(addPlan));
	}
}
