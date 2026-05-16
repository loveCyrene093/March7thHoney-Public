using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.GridFight;

public class PacketEEBMIAFNJMC : BasePacket
{
	public PacketEEBMIAFNJMC()
		: base(8494)
	{
		SetData(new EEBMIAFNJMC());
	}
}
