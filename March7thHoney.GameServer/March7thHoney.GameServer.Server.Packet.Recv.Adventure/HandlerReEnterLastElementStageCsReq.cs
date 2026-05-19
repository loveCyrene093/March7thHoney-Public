using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.GameServer.Game.Battle;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Adventure;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Adventure;

[Opcode(1452)]
public class HandlerReEnterLastElementStageCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		ReEnterLastElementStageCsReq reEnterLastElementStageCsReq = ReEnterLastElementStageCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		int stageId = (int)reEnterLastElementStageCsReq.StageId;
		GameData.FarmElementConfigData.TryGetValue(stageId, out FarmElementConfigExcel value);
		BattleInstance battleInstance = ((value == null) ? null : (await player.BattleManager.StartFarmElementStage(value)));
		BattleInstance battleInstance2 = battleInstance;
		if (battleInstance2 != null)
		{
			player.SceneInstance?.OnEnterStage();
			await connection.SendPacket(new PacketReEnterLastElementStageScRsp(battleInstance2, stageId));
		}
		else
		{
			await connection.SendPacket(new PacketReEnterLastElementStageScRsp());
		}
	}
}
