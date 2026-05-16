using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Scene;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Scene;

[Opcode(1422)]
public class HandlerUpdateGroupPropertyCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		UpdateGroupPropertyCsReq req = UpdateGroupPropertyCsReq.Parser.ParseFrom(data);
		if (req.FloorId != connection.Player.SceneInstance.FloorId)
		{
			await connection.SendPacket(new PacketUpdateGroupPropertyScRsp(Retcode.RetReqParaInvalid));
			return;
		}
		SceneInstance sceneInstance = connection.Player.SceneInstance;
		if (!sceneInstance.Groups.Contains((int)req.GroupId))
		{
			await connection.SendPacket(new PacketUpdateGroupPropertyScRsp(Retcode.RetGroupNotExist));
		}
		else
		{
			await connection.SendPacket(new PacketUpdateGroupPropertyScRsp(await sceneInstance.UpdateGroupProperty((int)req.GroupId, req.ELNCJFFJFIH, req.AOBABOGHFKJ), req));
		}
	}
}
