using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.GridFight;

public class PacketEMIDPCIJAEN : BasePacket
{
	public PacketEMIDPCIJAEN()
		: base(8638)
	{
		SetData(new EMIDPCIJAEN());
	}
}
