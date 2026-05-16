using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Mission;

public class PacketFinishCosumeItemMissionScRsp : BasePacket
{
	public PacketFinishCosumeItemMissionScRsp(uint subMissionId)
		: base(1237)
	{
		FinishCosumeItemMissionScRsp data = new FinishCosumeItemMissionScRsp
		{
			SubMissionId = subMissionId
		};
		SetData(data);
	}

	public PacketFinishCosumeItemMissionScRsp()
		: base(1237)
	{
		FinishCosumeItemMissionScRsp data = new FinishCosumeItemMissionScRsp
		{
			Retcode = 1u
		};
		SetData(data);
	}
}
