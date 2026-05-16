using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.DiceCombat;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.DiceCombat;

[Opcode(9298)]
public class HandlerV2FinishPveStageCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		V2FinishPveStageCsReq v2FinishPveStageCsReq = V2FinishPveStageCsReq.Parser.ParseFrom(data);
		connection.Player.ActivityManager.DiceCombat.RecordStageFinish(v2FinishPveStageCsReq.MMLKFJIAKKH, v2FinishPveStageCsReq.IsWin);
		await connection.SendPacket(new PacketV2FinishPveStageScRsp(v2FinishPveStageCsReq.MMLKFJIAKKH, v2FinishPveStageCsReq.IsWin));
	}
}
