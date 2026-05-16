using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Tutorial;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Tutorial;

[Opcode(1609)]
public class HandlerUnlockTutorialGuideCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		UnlockTutorialGuideCsReq unlockTutorialGuideCsReq = UnlockTutorialGuideCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		if (!player.TutorialGuideData.Tutorials.TryGetValue((int)unlockTutorialGuideCsReq.GroupId, out var _))
		{
			player.TutorialGuideData.Tutorials.Add((int)unlockTutorialGuideCsReq.GroupId, TutorialStatus.TutorialUnlock);
		}
		await connection.SendPacket(new PacketUnlockTutorialGuideScRsp(unlockTutorialGuideCsReq.GroupId));
	}
}
