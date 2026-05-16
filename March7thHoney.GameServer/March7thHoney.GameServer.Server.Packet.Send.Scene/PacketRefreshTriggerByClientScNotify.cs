using System.Collections.Generic;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Scene;

public class PacketRefreshTriggerByClientScNotify : BasePacket
{
	public PacketRefreshTriggerByClientScNotify(string triggerName, uint entityId, List<uint> targetIds)
		: base(1487)
	{
		RefreshTriggerByClientScNotify data = new RefreshTriggerByClientScNotify
		{
			TriggerName = triggerName,
			TriggerEntityId = entityId,
			TriggerTargetIdList = { (IEnumerable<uint>)targetIds }
		};
		SetData(data);
	}
}
