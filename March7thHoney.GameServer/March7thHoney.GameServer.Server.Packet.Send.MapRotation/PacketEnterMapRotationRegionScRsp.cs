using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.MapRotation;

public class PacketEnterMapRotationRegionScRsp : BasePacket
{
	public PacketEnterMapRotationRegionScRsp(MotionInfo motion)
		: base(6810)
	{
		EnterMapRotationRegionScRsp data = new EnterMapRotationRegionScRsp
		{
			Motion = motion,
			EnergyInfo = new RotaterEnergyInfo
			{
				CurNum = 5u,
				MaxNum = 5u
			}
		};
		SetData(data);
	}
}
