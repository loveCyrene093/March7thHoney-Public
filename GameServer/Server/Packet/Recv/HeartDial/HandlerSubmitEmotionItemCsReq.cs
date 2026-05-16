using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Scene;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Server.Packet.Send.HeartDial;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.HeartDial;

[Opcode(6314)]
public class HandlerSubmitEmotionItemCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SubmitEmotionItemCsReq req = SubmitEmotionItemCsReq.Parser.ParseFrom(data);
		GameData.HeartDialScriptData.TryGetValue((int)req.ScriptId, out HeartDialScriptExcel value);
		if (value != null)
		{
			HeartDialInfo changedInfo = connection.Player.HeartDialData.ChangeScriptEmotion((int)req.ScriptId, value.DefaultEmoType, HeartDialStepTypeEnum.UnLock);
			await connection.Player.SendPacket(new PacketHeartDialScriptChangeScNotify(HeartDialUnlockStatus.UnlockAll, changedInfo));
			await connection.Player.MissionManager.HandleFinishType(MissionFinishTypeEnum.HeartDialScriptListStep);
		}
		await connection.SendPacket(new PacketSubmitEmotionItemScRsp(req.ScriptId));
	}
}
