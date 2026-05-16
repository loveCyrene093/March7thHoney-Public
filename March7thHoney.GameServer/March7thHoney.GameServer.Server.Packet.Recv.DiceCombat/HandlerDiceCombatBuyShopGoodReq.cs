using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.DiceCombat;

namespace March7thHoney.GameServer.Server.Packet.Recv.DiceCombat;

[Opcode(9290)]
public class HandlerDiceCombatBuyShopGoodReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketDiceCombatBuyShopGoodScRsp());
	}
}
