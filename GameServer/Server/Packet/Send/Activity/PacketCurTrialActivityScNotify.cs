using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Activity;

public class PacketCurTrialActivityScNotify : BasePacket
{
	public PacketCurTrialActivityScNotify(uint stageId, TrialActivityStatus status)
		: base(2652)
	{
		CurTrialActivityScNotify data = new CurTrialActivityScNotify
		{
			ActivityStageId = stageId,
			Status = status
		};
		SetData(data);
	}
}
