using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Tutorial;

public class PacketFinishTutorialGuideScRsp : BasePacket
{
	public PacketFinishTutorialGuideScRsp(uint tutorialId)
		: base(1601)
	{
		FinishTutorialGuideScRsp finishTutorialGuideScRsp = new FinishTutorialGuideScRsp
		{
			TutorialGuide = new TutorialGuide
			{
				Id = tutorialId,
				Status = TutorialStatus.TutorialFinish
			},
			Reward = new ItemList()
		};
		finishTutorialGuideScRsp.Reward.ItemList_.Add(new March7thHoney.Proto.Item
		{
			ItemId = 1u,
			Num = 1u
		});
		SetData(finishTutorialGuideScRsp);
	}
}
