using System.Linq;
using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Scene.Entity;
using March7thHoney.GameServer.Server.Packet.Send.MiscModule;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.MiscModule;

[Opcode(4108)]
public class HandlerMazeKillDirectCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		MazeKillDirectCsReq req = MazeKillDirectCsReq.Parser.ParseFrom(data);
		foreach (uint item in req.EntityList.ToList())
		{
			if (connection.Player.SceneInstance.Entities.TryGetValue((int)item, out BaseGameEntity value))
			{
				if (value is EntityMonster entityMonster)
				{
					await entityMonster.Kill();
				}
				else
				{
					connection.Player.SceneInstance.Entities.Remove((int)item);
				}
			}
		}
		await connection.SendPacket(new PacketMazeKillDirectScRsp(req.EntityList.ToList()));
	}
}
