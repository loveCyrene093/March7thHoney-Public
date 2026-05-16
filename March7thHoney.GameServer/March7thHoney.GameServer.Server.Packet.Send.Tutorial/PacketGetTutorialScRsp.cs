using System.Collections.Generic;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Tutorial;

public class PacketGetTutorialScRsp : BasePacket
{
	public PacketGetTutorialScRsp(PlayerInstance player)
		: base(1610)
	{
		GetTutorialScRsp getTutorialScRsp = new GetTutorialScRsp();
		foreach (KeyValuePair<int, TutorialStatus> tutorial in player.TutorialData.Tutorials)
		{
			getTutorialScRsp.TutorialList.Add(new March7thHoney.Proto.Tutorial
			{
				Id = (uint)tutorial.Key,
				Status = tutorial.Value
			});
		}
		SetData(getTutorialScRsp);
	}
}
