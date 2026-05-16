using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Recommend;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Recommend;

[Opcode(2405)]
public class HandlerGetBigDataRecommendCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GetBigDataRecommendCsReq getBigDataRecommendCsReq = GetBigDataRecommendCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketGetBigDataRecommendScRsp(getBigDataRecommendCsReq.EquipAvatar, getBigDataRecommendCsReq.BigDataRecommendType));
	}
}
