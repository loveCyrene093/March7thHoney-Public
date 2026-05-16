using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Tutorial;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Tutorial;

[Opcode(1639)]
public class HandlerFinishTutorialGuideCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		FinishTutorialGuideCsReq req = FinishTutorialGuideCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		if (player.TutorialGuideData.Tutorials.TryGetValue((int)req.GroupId, out var value) && value != TutorialStatus.TutorialFinish)
		{
			await player.InventoryManager.AddItem(1, 1, notify: false);
			player.TutorialGuideData.Tutorials[(int)req.GroupId] = TutorialStatus.TutorialFinish;
		}
		await connection.SendPacket(new PacketFinishTutorialGuideScRsp(req.GroupId));
	}
}
