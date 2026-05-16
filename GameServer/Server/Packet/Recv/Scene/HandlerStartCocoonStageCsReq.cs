using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Battle;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Scene;

[Opcode(1425)]
public class HandlerStartCocoonStageCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		StartCocoonStageCsReq req = StartCocoonStageCsReq.Parser.ParseFrom(data);
		BattleInstance battleInstance = await connection.Player.BattleManager.StartCocoonStage((int)req.CocoonId, (int)req.Wave, (int)req.WorldLevel);
		connection.Player.SceneInstance?.OnEnterStage();
		if (battleInstance != null)
		{
			await connection.SendPacket(new PacketStartCocoonStageScRsp(battleInstance, (int)req.CocoonId, (int)req.Wave));
		}
		else
		{
			await connection.SendPacket(new PacketStartCocoonStageScRsp());
		}
	}
}
