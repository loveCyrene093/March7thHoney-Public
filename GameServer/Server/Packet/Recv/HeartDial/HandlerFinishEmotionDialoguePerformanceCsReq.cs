using System.Threading.Tasks;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Server.Packet.Send.HeartDial;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.HeartDial;

[Opcode(6309)]
public class HandlerFinishEmotionDialoguePerformanceCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		FinishEmotionDialoguePerformanceCsReq req = FinishEmotionDialoguePerformanceCsReq.Parser.ParseFrom(data);
		await connection.Player.MissionManager.HandleFinishType(MissionFinishTypeEnum.HeartDialDialoguePerformanceFinish, $"HeartDial_{req.DialogueId}");
		await connection.SendPacket(new PacketFinishEmotionDialoguePerformanceScRsp(req.ScriptId, req.DialogueId));
	}
}
