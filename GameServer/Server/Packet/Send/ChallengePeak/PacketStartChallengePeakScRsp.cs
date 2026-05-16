using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.ChallengePeak;

public class PacketStartChallengePeakScRsp : BasePacket
{
	public PacketStartChallengePeakScRsp(Retcode retcode)
		: base(8927)
	{
		StartChallengePeakScRsp data = new StartChallengePeakScRsp
		{
			Retcode = (uint)retcode
		};
		SetData(data);
	}
}
