using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Scene;

[Opcode(1469)]
public class HandlerSceneEntityTeleportCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SceneEntityTeleportCsReq req = SceneEntityTeleportCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		if (req.EntryId != player.Data.EntryId)
		{
			await player.EnterScene((int)req.EntryId, 0, sendPacket: false);
		}
		player.MoveTo(req.EntityMotion);
		await connection.SendPacket(new PacketSceneEntityTeleportScRsp(req.EntityMotion));
	}
}
