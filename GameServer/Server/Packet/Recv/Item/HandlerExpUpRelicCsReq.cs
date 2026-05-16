using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Item;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Item;

[Opcode(504)]
public class HandlerExpUpRelicCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		ExpUpRelicCsReq expUpRelicCsReq = ExpUpRelicCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketExpUpRelicScRsp(await connection.Player.InventoryManager.LevelUpRelic((int)expUpRelicCsReq.RelicUniqueId, expUpRelicCsReq.CostData)));
	}
}
