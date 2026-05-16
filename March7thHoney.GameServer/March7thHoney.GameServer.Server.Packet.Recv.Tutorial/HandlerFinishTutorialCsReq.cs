using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Tutorial;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Tutorial;

[Opcode(1663)]
public class HandlerFinishTutorialCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		FinishTutorialCsReq finishTutorialCsReq = FinishTutorialCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		if (player.TutorialData.Tutorials.TryGetValue((int)finishTutorialCsReq.TutorialId, out var value) && value != TutorialStatus.TutorialFinish)
		{
			player.TutorialData.Tutorials[(int)finishTutorialCsReq.TutorialId] = TutorialStatus.TutorialFinish;
		}
		await connection.SendPacket(new PacketFinishTutorialScRsp(finishTutorialCsReq.TutorialId));
	}
}
