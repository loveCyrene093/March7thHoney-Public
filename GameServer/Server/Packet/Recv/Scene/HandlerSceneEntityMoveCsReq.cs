using System.Threading.Tasks;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Server.Packet.Recv.Scene;

[Opcode(1491)]
public class HandlerSceneEntityMoveCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SceneEntityMoveCsReq sceneEntityMoveCsReq = SceneEntityMoveCsReq.Parser.ParseFrom(data);
		if (sceneEntityMoveCsReq != null)
		{
			foreach (EntityMotion entityMotion in sceneEntityMoveCsReq.EntityMotionList)
			{
				if (connection.Player.SceneInstance.AvatarInfo.ContainsKey((int)entityMotion.EntityId))
				{
					connection.Player.Data.Pos = entityMotion.Motion.Pos.ToPosition();
					connection.Player.Data.Rot = entityMotion.Motion.Rot.ToPosition();
					await connection.Player.OnMove();
				}
			}
		}
		await connection.SendPacket(1410);
	}
}
