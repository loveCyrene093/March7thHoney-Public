using System.Collections.Generic;
using System.Threading.Tasks;
using Google.Protobuf.Collections;
using March7thHoney.GameServer.Server.Packet.Send.ChallengePeak;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.ChallengePeak;

[Opcode(8947)]
public class HandlerTakeChallengePeakRewardCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		TakeChallengePeakRewardCsReq req = TakeChallengePeakRewardCsReq.Parser.ParseFrom(data);
		RepeatedField<uint> requestRewardIds = ((req.RewardId.Count > 0) ? req.RewardId : req.NormalRewardIdList);
		List<ChallengePeakRewardGroup> rewardGroups = await connection.Player.ChallengePeakManager.TakeRewards((int)req.PeakGroupId, requestRewardIds);
		await connection.SendPacket(new PacketTakeChallengePeakRewardScRsp(req.PeakGroupId, rewardGroups));
	}
}
