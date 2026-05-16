using System.Linq;
using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Scene;

[Opcode(1456)]
public class HandlerRefreshTriggerByClientCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		RefreshTriggerByClientCsReq req = RefreshTriggerByClientCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketRefreshTriggerByClientScRsp(await connection.Player.SceneInstance.TriggerSummonUnit((int)req.TriggerEntityId, req.TriggerName, req.TriggerTargetIdList.ToList()), req.TriggerName, req.TriggerEntityId));
	}
}
