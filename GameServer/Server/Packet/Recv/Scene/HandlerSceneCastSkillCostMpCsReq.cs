using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Scene;

[Opcode(1437)]
public class HandlerSceneCastSkillCostMpCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SceneCastSkillCostMpCsReq req = SceneCastSkillCostMpCsReq.Parser.ParseFrom(data);
		await connection.Player.LineupManager.CostMp(1, req.CastEntityId);
		await connection.SendPacket(new PacketSceneCastSkillCostMpScRsp((int)req.CastEntityId));
	}
}
