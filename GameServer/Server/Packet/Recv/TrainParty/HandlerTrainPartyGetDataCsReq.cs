using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Game.TrainParty;
using March7thHoney.GameServer.Server.Packet.Send.TrainParty;

namespace March7thHoney.GameServer.Server.Packet.Recv.TrainParty;

[Opcode(8091)]
public class HandlerTrainPartyGetDataCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		PlayerInstance player = connection.Player;
		TrainPartyManager manager = player.TrainPartyManager;
		manager.EnsureDefaults();
		await connection.SendPacket(new PacketTrainPartyGetDataScRsp(player));
		await connection.SendPacket(new PacketTrainPartyBuildRoomScNotify(player));
		await connection.SendPacket(new PacketTrainWorldIdChangeScNotify(manager.GetWorldId()));
		await connection.SendPacket(new PacketTrainRefreshTimeNotify(manager.GetRefreshTime()));
	}
}
