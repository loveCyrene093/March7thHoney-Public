using System.Collections.Generic;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Tutorial;

public class PacketGetTutorialGuideScRsp : BasePacket
{
	public PacketGetTutorialGuideScRsp(PlayerInstance player)
		: base(1695)
	{
		GetTutorialGuideScRsp getTutorialGuideScRsp = new GetTutorialGuideScRsp();
		foreach (KeyValuePair<int, TutorialStatus> item in player.TutorialGuideData?.Tutorials ?? new Dictionary<int, TutorialStatus>())
		{
			getTutorialGuideScRsp.TutorialGuideList.Add(new TutorialGuide
			{
				Id = (uint)item.Key,
				Status = item.Value
			});
		}
		SetData(getTutorialGuideScRsp);
	}
}
