using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.TrainCakeCatch;

public class PacketTrainCakeCatchDiyScRsp : BasePacket
{
	public PacketTrainCakeCatchDiyScRsp(FOFNOBHLKGO diy)
		: base(9649)
	{
		SetData(new TrainCakeCatchDiyScRsp
		{
			PEOECDDANNP = diy
		});
	}
}
