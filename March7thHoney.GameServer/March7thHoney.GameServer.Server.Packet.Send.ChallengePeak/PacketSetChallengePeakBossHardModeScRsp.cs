using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.ChallengePeak;

public class PacketSetChallengePeakBossHardModeScRsp : BasePacket
{
	public PacketSetChallengePeakBossHardModeScRsp(uint groupId, bool isHard)
		: base(8945)
	{
		SetChallengePeakBossHardModeScRsp data = new SetChallengePeakBossHardModeScRsp
		{
			IsHardMode = isHard,
			PeakGroupId = groupId
		};
		SetData(data);
	}
}
