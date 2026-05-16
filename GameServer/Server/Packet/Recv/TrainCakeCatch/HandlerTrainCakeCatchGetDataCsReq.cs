using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.TrainCakeCatch;

namespace March7thHoney.GameServer.Server.Packet.Recv.TrainCakeCatch;

[Opcode(9745)]
public class HandlerTrainCakeCatchGetDataCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		PlayerInstance player = connection.Player;
		await player.TrainCakeCatchManager.UnlockAllPerformanceQuests();
		await connection.SendPacket(new PacketTrainCakeCatchGetDataScRsp(player));
	}
}
