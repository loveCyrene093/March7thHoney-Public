using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.RechargeGift;

namespace March7thHoney.GameServer.Server.Packet.Recv.RechargeGift;

[Opcode(8361)]
public class HandlerGetRechargeGiftInfoCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetRechargeGiftInfoScRsp());
	}
}
