using System.Threading.Tasks;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Item;

[Opcode(563)]
public class HandlerRankUpEquipmentCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		RankUpEquipmentCsReq rankUpEquipmentCsReq = RankUpEquipmentCsReq.Parser.ParseFrom(data);
		await connection.Player.InventoryManager.RankUpEquipment((int)rankUpEquipmentCsReq.EquipmentUniqueId, rankUpEquipmentCsReq.CostData);
		await connection.SendPacket(526);
	}
}
