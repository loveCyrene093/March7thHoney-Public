using System.Threading.Tasks;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Server.Packet.Send.HeartDial;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.HeartDial;

[Opcode(6394)]
public class HandlerChangeScriptEmotionCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		ChangeScriptEmotionCsReq changeScriptEmotionCsReq = ChangeScriptEmotionCsReq.Parser.ParseFrom(data);
		connection.Player.HeartDialData.ChangeScriptEmotion((int)changeScriptEmotionCsReq.ScriptId, (HeartDialEmoTypeEnum)changeScriptEmotionCsReq.TargetEmotionType);
		await connection.SendPacket(new PacketChangeScriptEmotionScRsp(changeScriptEmotionCsReq.ScriptId, changeScriptEmotionCsReq.TargetEmotionType));
	}
}
