using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Battle;
using March7thHoney.GameServer.Server.Packet.Send.Adventure;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Adventure;

[Opcode(1314)]
public class HandlerQuickStartCocoonStageCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		QuickStartCocoonStageCsReq req = QuickStartCocoonStageCsReq.Parser.ParseFrom(data);
		int wave = (int)((req.Wave == 0) ? 1 : req.Wave);
		if (wave <= 0)
		{
			wave = 1;
		}
		BattleInstance battleInstance = await connection.Player.BattleManager.StartCocoonStage((int)req.CocoonId, wave, (int)req.WorldLevel);
		if (battleInstance != null)
		{
			connection.Player.SceneInstance?.OnEnterStage();
			await connection.SendPacket(new PacketQuickStartCocoonStageScRsp(battleInstance, (int)req.CocoonId, wave));
		}
		else
		{
			await connection.SendPacket(new PacketQuickStartCocoonStageScRsp());
		}
	}
}
