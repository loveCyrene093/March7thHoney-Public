using System.Threading.Tasks;
using March7thHoney.Enums.Item;
using March7thHoney.GameServer.Server.Packet.Send.Item;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Item;

[Opcode(514)]
public class HandlerLockEquipmentCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		LockEquipmentCsReq lockEquipmentCsReq = LockEquipmentCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketLockEquipmentScRsp(await connection.Player.InventoryManager.LockItems(lockEquipmentCsReq.EquipmentIdList, lockEquipmentCsReq.IsLocked, ItemMainTypeEnum.Equipment)));
	}
}
