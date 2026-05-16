using System.Threading.Tasks;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Scene;

[Opcode(1444)]
public class HandlerSceneEnterStageCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SceneEnterStageCsReq sceneEnterStageCsReq = SceneEnterStageCsReq.Parser.ParseFrom(data);
		await connection.Player.BattleManager.StartStage((int)sceneEnterStageCsReq.EventId);
	}
}
