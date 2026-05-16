using System.Linq;
using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Mission;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Mission;

[Opcode(1294)]
public class HandlerFinishTalkMissionCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		FinishTalkMissionCsReq req = FinishTalkMissionCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		await player.MissionManager.HandleTalkStr(req.TalkStr);
		if (req.CustomValueList != null && req.CustomValueList.Count > 0)
		{
			await player.MissionManager.HandleCustomValue(req.CustomValueList.ToList(), (int)req.SubMissionId);
		}
		await connection.SendPacket(new PacketFinishTalkMissionScRsp(req.TalkStr));
	}
}
