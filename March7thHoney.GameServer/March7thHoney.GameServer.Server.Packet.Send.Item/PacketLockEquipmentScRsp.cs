using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Item;

public class PacketLockEquipmentScRsp : BasePacket
{
	public PacketLockEquipmentScRsp(bool success)
		: base(518)
	{
		LockEquipmentScRsp lockEquipmentScRsp = new LockEquipmentScRsp();
		if (!success)
		{
			lockEquipmentScRsp.Retcode = 1u;
		}
		SetData(lockEquipmentScRsp);
	}
}
