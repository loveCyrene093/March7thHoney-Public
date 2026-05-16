using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Challenge;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Challenge;

[Opcode(1704)]
public class HandlerTakeChallengeRewardCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		TakeChallengeRewardCsReq req = TakeChallengeRewardCsReq.Parser.ParseFrom(data);
		List<TakenChallengeRewardInfo> rewardInfos = await connection.Player.ChallengeManager.TakeRewards((int)req.GroupId);
		await connection.SendPacket(new PacketTakeChallengeRewardScRsp((int)req.GroupId, rewardInfos));
	}
}
