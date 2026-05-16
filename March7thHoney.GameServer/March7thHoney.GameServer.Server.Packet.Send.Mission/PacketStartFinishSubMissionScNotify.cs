using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Mission;

public class PacketStartFinishSubMissionScNotify : BasePacket
{
	public PacketStartFinishSubMissionScNotify(int missionId)
		: base(1228)
	{
		StartFinishSubMissionScNotify data = new StartFinishSubMissionScNotify
		{
			SubMissionId = (uint)missionId
		};
		SetData(data);
	}
}
