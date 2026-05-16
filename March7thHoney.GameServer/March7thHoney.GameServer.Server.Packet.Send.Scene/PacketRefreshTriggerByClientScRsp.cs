using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Scene;

public class PacketRefreshTriggerByClientScRsp : BasePacket
{
	public PacketRefreshTriggerByClientScRsp(Retcode ret, string triggerName, uint entityId)
		: base(1445)
	{
		RefreshTriggerByClientScRsp data = new RefreshTriggerByClientScRsp
		{
			Retcode = (uint)ret,
			TriggerName = triggerName,
			RefreshTrigger = (ret == Retcode.RetSucc),
			TriggerEntityId = entityId
		};
		SetData(data);
	}
}
