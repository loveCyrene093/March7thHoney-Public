using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.MapRotation;

public class PacketInteractChargerScRsp : BasePacket
{
	public PacketInteractChargerScRsp(ChargerInfo chargerInfo)
		: base(6895)
	{
		InteractChargerScRsp data = new InteractChargerScRsp
		{
			ChargerInfo = chargerInfo
		};
		SetData(data);
	}
}
