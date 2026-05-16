using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Database.Friend;
using March7thHoney.GameServer.Server.Packet.Send.Challenge;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Challenge;

[Opcode(1772)]
public class HandlerGetChallengeGroupStatisticsCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GetChallengeGroupStatisticsCsReq req = GetChallengeGroupStatisticsCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketGetChallengeGroupStatisticsScRsp(req.GroupId, connection.Player.FriendRecordData.ChallengeGroupStatistics.Values.FirstOrDefault((ChallengeGroupStatisticsPb x) => x.GroupId == req.GroupId)));
	}
}
