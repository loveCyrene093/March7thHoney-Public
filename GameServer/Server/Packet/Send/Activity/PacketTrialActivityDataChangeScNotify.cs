using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Activity;

public class PacketTrialActivityDataChangeScNotify : BasePacket
{
	public PacketTrialActivityDataChangeScNotify(uint stageId)
		: base(2678)
	{
		TrialActivityDataChangeScNotify data = new TrialActivityDataChangeScNotify
		{
			TrialActivityInfo = 
			{
				StageId = stageId
			}
		};
		SetData(data);
	}
}
