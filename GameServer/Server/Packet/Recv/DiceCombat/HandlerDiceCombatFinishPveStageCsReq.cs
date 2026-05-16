using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.DiceCombat;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.DiceCombat;

[Opcode(9262)]
public class HandlerDiceCombatFinishPveStageCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		DiceCombatFinishPveStageCsReq diceCombatFinishPveStageCsReq = DiceCombatFinishPveStageCsReq.Parser.ParseFrom(data);
		connection.Player.ActivityManager.DiceCombat.RecordStageFinish(diceCombatFinishPveStageCsReq.MMLKFJIAKKH, diceCombatFinishPveStageCsReq.IsWin);
		await connection.SendPacket(new PacketDiceCombatFinishPveStageScRsp(diceCombatFinishPveStageCsReq.MMLKFJIAKKH, diceCombatFinishPveStageCsReq.IsWin));
	}
}
