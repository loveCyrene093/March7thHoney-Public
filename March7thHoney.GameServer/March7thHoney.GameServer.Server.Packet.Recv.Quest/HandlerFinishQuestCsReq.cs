using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Quest;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Quest;

[Opcode(926)]
public class HandlerFinishQuestCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		FinishQuestCsReq finishQuestCsReq = FinishQuestCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketFinishQuestScRsp(await connection.Player.QuestManager.FinishQuestByClient((int)finishQuestCsReq.QuestId)));
	}
}
