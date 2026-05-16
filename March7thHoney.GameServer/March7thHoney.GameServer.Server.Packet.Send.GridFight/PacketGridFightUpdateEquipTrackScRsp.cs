using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.GridFight;

public class PacketGridFightUpdateEquipTrackScRsp : BasePacket
{
	public PacketGridFightUpdateEquipTrackScRsp()
		: base(8669)
	{
		SetData(new GridFightUpdateEquipTrackScRsp());
	}
}
