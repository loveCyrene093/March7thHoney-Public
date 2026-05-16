using System.Linq;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.StoryLine;

public class PacketGetStoryLineInfoScRsp : BasePacket
{
	public PacketGetStoryLineInfoScRsp(PlayerInstance player)
		: base(6210)
	{
		GetStoryLineInfoScRsp data = new GetStoryLineInfoScRsp
		{
			CurStoryLineId = (uint)player.StoryLineManager.StoryLineData.CurStoryLineId,
			UnfinishedStoryLineIdList = { player.StoryLineManager.StoryLineData.RunningStoryLines.Keys.Select((int x) => (uint)x) }
		};
		SetData(data);
	}
}
