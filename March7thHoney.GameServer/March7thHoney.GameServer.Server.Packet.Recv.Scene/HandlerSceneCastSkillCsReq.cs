using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Battle;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Scene;

[Opcode(1414)]
public class HandlerSceneCastSkillCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SceneCastSkillCsReq req = SceneCastSkillCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		SkillResultData res = await player.SceneSkillManager.OnCast(req);
		await connection.SendPacket(new PacketSceneCastSkillScRsp(res.RetCode, req.CastEntityId, res.Instance, res.TriggerBattleInfos ?? new List<HitMonsterInstance>()));
		if (res.Instance != null)
		{
			await player.SceneInstance.OnEnterStage();
		}
	}
}
