using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Tutorial;

public class PacketUnlockTutorialScRsp : BasePacket
{
	public PacketUnlockTutorialScRsp(uint tutorialId)
		: base(1618)
	{
		UnlockTutorialScRsp data = new UnlockTutorialScRsp
		{
			Tutorial = new March7thHoney.Proto.Tutorial
			{
				Id = tutorialId,
				Status = TutorialStatus.TutorialUnlock
			}
		};
		SetData(data);
	}
}
