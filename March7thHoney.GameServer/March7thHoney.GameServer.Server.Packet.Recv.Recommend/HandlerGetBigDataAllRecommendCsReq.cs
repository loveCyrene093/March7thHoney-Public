using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Recommend;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Recommend;

[Opcode(2447)]
public class HandlerGetBigDataAllRecommendCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GetBigDataAllRecommendCsReq getBigDataAllRecommendCsReq = GetBigDataAllRecommendCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketGetBigDataAllRecommendScRsp(getBigDataAllRecommendCsReq.BigDataRecommendType));
	}
}
