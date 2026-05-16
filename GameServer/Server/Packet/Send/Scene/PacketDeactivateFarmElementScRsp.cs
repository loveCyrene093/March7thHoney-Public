using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Scene;

public class PacketDeactivateFarmElementScRsp : BasePacket
{
	public PacketDeactivateFarmElementScRsp(uint id)
		: base(1405)
	{
		DeactivateFarmElementScRsp data = new DeactivateFarmElementScRsp
		{
			EntityId = id
		};
		SetData(data);
	}
}
