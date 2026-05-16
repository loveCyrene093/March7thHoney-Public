using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Mission;

public class PacketStartFinishMainMissionScNotify : BasePacket
{
	public PacketStartFinishMainMissionScNotify(int missionId)
		: base(1265)
	{
		StartFinishMainMissionScNotify data = new StartFinishMainMissionScNotify
		{
			MainMissionId = (uint)missionId
		};
		SetData(data);
	}
}
