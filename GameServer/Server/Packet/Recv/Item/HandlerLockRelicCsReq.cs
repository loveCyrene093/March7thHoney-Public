using System.Threading.Tasks;
using March7thHoney.Enums.Item;
using March7thHoney.GameServer.Server.Packet.Send.Item;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Item;

[Opcode(572)]
public class HandlerLockRelicCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		LockRelicCsReq lockRelicCsReq = LockRelicCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketLockRelicScRsp(await connection.Player.InventoryManager.LockItems(lockRelicCsReq.RelicIds, lockRelicCsReq.IsLocked, ItemMainTypeEnum.Relic)));
	}
}
