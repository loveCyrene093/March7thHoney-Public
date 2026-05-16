using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Avatar;

public class PacketUnlockSkilltreeScRsp : BasePacket
{
	public PacketUnlockSkilltreeScRsp(Retcode retCode)
		: base(318)
	{
		UnlockSkilltreeScRsp data = new UnlockSkilltreeScRsp
		{
			Retcode = (uint)retCode
		};
		SetData(data);
	}

	public PacketUnlockSkilltreeScRsp(uint pointId, uint level)
		: base(318)
	{
		UnlockSkilltreeScRsp data = new UnlockSkilltreeScRsp
		{
			PointId = pointId,
			Level = level
		};
		SetData(data);
	}
}
