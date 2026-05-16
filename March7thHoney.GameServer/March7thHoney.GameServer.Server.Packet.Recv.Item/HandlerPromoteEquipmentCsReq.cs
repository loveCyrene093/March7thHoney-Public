using System.Threading.Tasks;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Item;

[Opcode(594)]
public class HandlerPromoteEquipmentCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		PromoteEquipmentCsReq promoteEquipmentCsReq = PromoteEquipmentCsReq.Parser.ParseFrom(data);
		await connection.Player.InventoryManager.PromoteEquipment((int)promoteEquipmentCsReq.EquipmentUniqueId);
		await connection.SendPacket(595);
	}
}
