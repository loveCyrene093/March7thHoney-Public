using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.TrainCakeCatch;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.TrainCakeCatch;

[Opcode(9716)]
public class HandlerTrainCakeCatchDiyCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		TrainCakeCatchDiyCsReq trainCakeCatchDiyCsReq = TrainCakeCatchDiyCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		FOFNOBHLKGO diy = player.TrainCakeCatchManager.ApplyDiy(trainCakeCatchDiyCsReq.PEOECDDANNP ?? new FOFNOBHLKGO());
		await connection.SendPacket(new PacketTrainCakeCatchDiyScRsp(diy));
		await player.TrainCakeCatchManager.BroadcastRoomSnapshotAsync();
	}
}
