using System.Threading.Tasks;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Avatar;

[Opcode(339)]
public class HandlerTakeOffEquipmentCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		TakeOffEquipmentCsReq takeOffEquipmentCsReq = TakeOffEquipmentCsReq.Parser.ParseFrom(data);
		await connection.Player.InventoryManager.UnequipEquipment((int)takeOffEquipmentCsReq.AvatarId);
		await connection.SendPacket(301);
	}
}
