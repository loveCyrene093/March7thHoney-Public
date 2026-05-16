using System.Collections.Generic;
using System.Linq;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Mission;

public class PacketFinishedMissionScNotify : BasePacket
{
	public PacketFinishedMissionScNotify(IEnumerable<int> missionIds)
		: base(1220)
	{
		FinishedMissionScNotify finishedMissionScNotify = new FinishedMissionScNotify();
		finishedMissionScNotify.FinishedMissionId.AddRange((from x in missionIds
			where x > 0
			select (uint)x).Distinct());
		SetData(finishedMissionScNotify);
	}

	public PacketFinishedMissionScNotify(int missionId)
		: this(new _003C_003Ez__ReadOnlySingleElementList<int>(missionId))
	{
	}
}
