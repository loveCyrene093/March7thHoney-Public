using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Item;

public class PacketLockRelicScRsp : BasePacket
{
	public PacketLockRelicScRsp(bool success)
		: base(532)
	{
		LockRelicScRsp lockRelicScRsp = new LockRelicScRsp();
		if (!success)
		{
			lockRelicScRsp.Retcode = 1u;
		}
		SetData(lockRelicScRsp);
	}
}
