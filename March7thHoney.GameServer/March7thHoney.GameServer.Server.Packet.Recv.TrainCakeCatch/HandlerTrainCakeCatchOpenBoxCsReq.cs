using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;

namespace March7thHoney.GameServer.Server.Packet.Recv.TrainCakeCatch;

[Opcode(9628)]
public class HandlerTrainCakeCatchOpenBoxCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		BasePacket basePacket = new BasePacket(9657);
		PlayerInstance player = connection.Player;
		basePacket.SetData(player.TrainCakeCatchManager.OpenBox());
		await connection.SendPacket(basePacket);
		await player.TrainCakeCatchManager.BroadcastRoomSnapshotAsync();
	}
}
