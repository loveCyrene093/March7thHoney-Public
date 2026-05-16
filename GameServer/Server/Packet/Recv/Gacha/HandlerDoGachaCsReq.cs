using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Gacha;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Gacha;

[Opcode(1994)]
public class HandlerDoGachaCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		DoGachaCsReq doGachaCsReq = DoGachaCsReq.Parser.ParseFrom(data);
		DoGachaScRsp doGachaScRsp = await connection.Player.GachaManager.DoGacha((int)doGachaCsReq.GachaId, (int)doGachaCsReq.GachaNum);
		if (doGachaScRsp != null)
		{
			await connection.SendPacket(new PacketDoGachaScRsp(doGachaScRsp));
		}
		else
		{
			await connection.SendPacket(new PacketDoGachaScRsp());
		}
	}
}
