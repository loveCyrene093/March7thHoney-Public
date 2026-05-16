using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Scene;

[Opcode(1462)]
public class HandlerEnterSceneCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		EnterSceneCsReq req = EnterSceneCsReq.Parser.ParseFrom(data);
		int storyLineId = (int)(req.SceneIdentifier?.GameStoryLineId ?? 0);
		await connection.SendPacket(new PacketEnterSceneScRsp(await connection.Player.EnterScene((int)req.EntryId, (int)req.TeleportId, sendPacket: true, storyLineId, req.IsCloseMap), req.IsCloseMap, storyLineId));
	}
}
