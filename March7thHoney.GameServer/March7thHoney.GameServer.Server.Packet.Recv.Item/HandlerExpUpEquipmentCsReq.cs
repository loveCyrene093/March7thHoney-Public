using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Item;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Item;

[Opcode(539)]
public class HandlerExpUpEquipmentCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		ExpUpEquipmentCsReq expUpEquipmentCsReq = ExpUpEquipmentCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketExpUpEquipmentScRsp(await connection.Player.InventoryManager.LevelUpEquipment((int)expUpEquipmentCsReq.EquipmentUniqueId, expUpEquipmentCsReq.CostData)));
	}
}
