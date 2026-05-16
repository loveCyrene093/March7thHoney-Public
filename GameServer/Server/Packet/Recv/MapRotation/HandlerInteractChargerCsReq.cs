using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.MapRotation;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.MapRotation;

[Opcode(6894)]
public class HandlerInteractChargerCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		InteractChargerCsReq interactChargerCsReq = InteractChargerCsReq.Parser.ParseFrom(data);
		connection.Player.ChargerNum = 5;
		await connection.SendPacket(new PacketInteractChargerScRsp(interactChargerCsReq.ChargerInfo));
		await connection.SendPacket(new PacketUpdateEnergyScNotify(connection.Player.ChargerNum, 5));
	}
}
