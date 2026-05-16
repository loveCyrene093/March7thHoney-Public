using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Battle;
using March7thHoney.GameServer.Game.GridFight;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.GridFight;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.GridFight;

[Opcode(8507)]
public class HandlerGridFightEnterBattleStageCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GridFightEnterBattleStageCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		GridFightInstance inst = player.GridFightManager?.GridFightInstance;
		BattleInstance battle = null;
		if (inst != null)
		{
			battle = inst.StartBattle();
			await connection.SendPacket(new PacketGridFightSeasonHandBookNotify(inst.BuildHandbookNotifyForBattle()));
		}
		await connection.SendPacket(new PacketGridFightEnterBattleStageScRsp(inst, battle));
	}
}
