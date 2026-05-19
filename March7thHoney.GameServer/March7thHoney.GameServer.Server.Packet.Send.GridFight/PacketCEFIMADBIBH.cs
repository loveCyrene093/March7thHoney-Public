using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.GridFight;

public class PacketCEFIMADBIBH : BasePacket
{
	public PacketCEFIMADBIBH()
		: base(8556)
	{
		SetData(new CEFIMADBIBH());
	}
}
