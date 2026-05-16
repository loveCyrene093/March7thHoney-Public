using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.GridFight;

public class PacketJNNNJBAOCOB : BasePacket
{
	public PacketJNNNJBAOCOB()
		: base(8661)
	{
		SetData(new JNNNJBAOCOB());
	}
}
