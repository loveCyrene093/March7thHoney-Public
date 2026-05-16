using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Tutorial;

public class PacketFinishTutorialScRsp : BasePacket
{
	public PacketFinishTutorialScRsp(uint tutorialId)
		: base(1626)
	{
		FinishTutorialScRsp data = new FinishTutorialScRsp
		{
			Tutorial = new March7thHoney.Proto.Tutorial
			{
				Id = tutorialId,
				Status = TutorialStatus.TutorialFinish
			}
		};
		SetData(data);
	}
}
