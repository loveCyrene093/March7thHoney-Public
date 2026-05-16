using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Tutorial;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Tutorial;

[Opcode(1614)]
public class HandlerUnlockTutorialCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		UnlockTutorialCsReq unlockTutorialCsReq = UnlockTutorialCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		if (!player.TutorialData.Tutorials.TryGetValue((int)unlockTutorialCsReq.TutorialId, out var _))
		{
			player.TutorialData.Tutorials.Add((int)unlockTutorialCsReq.TutorialId, TutorialStatus.TutorialUnlock);
		}
		await connection.SendPacket(new PacketUnlockTutorialScRsp(unlockTutorialCsReq.TutorialId));
	}
}
