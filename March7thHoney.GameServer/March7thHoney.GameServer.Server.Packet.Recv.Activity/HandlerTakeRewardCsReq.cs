using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Activity;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Activity;

[Opcode(2670)]
public class HandlerTakeRewardCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		TakeRewardCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketTakeRewardScRsp());
	}
}
