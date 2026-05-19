using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.TrainCakeCatch;

[Opcode(9666)]
public class HandlerRoomMovementCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		MKLFLKDHLIC req = MKLFLKDHLIC.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		if (player?.TrainCakeCatchManager != null)
		{
			await player.TrainCakeCatchManager.HandleRoomMovement(req);
		}
	}
}
