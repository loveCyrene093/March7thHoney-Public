using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.TrainParty;

public class PacketTrainPartyBuildSelfDisplayAreaDiyScRsp : BasePacket
{
	public PacketTrainPartyBuildSelfDisplayAreaDiyScRsp(KJGMAEGNBKL selfDisplay)
		: base(8005)
	{
		SetData(new TrainPartyBuildSelfDisplayAreaDiyScRsp
		{
			ICJFLLDCFHM = selfDisplay
		});
	}
}
