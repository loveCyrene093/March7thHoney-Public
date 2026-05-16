using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.StoryLine;

public class PacketStoryLineInfoScNotify : BasePacket
{
	public PacketStoryLineInfoScNotify(PlayerInstance player)
		: base(6294)
	{
		List<uint> list = player.StoryLineManager?.StoryLineData.RunningStoryLines.Keys.Select((int x) => (uint)x).ToList() ?? new List<uint>();
		list.Insert(0, 0u);
		StoryLineInfoScNotify storyLineInfoScNotify = new StoryLineInfoScNotify
		{
			CurStoryLineId = (uint)(player.StoryLineManager?.StoryLineData.CurStoryLineId ?? 0),
			UnfinishedStoryLineIdList = { (IEnumerable<uint>)list }
		};
		if (!storyLineInfoScNotify.UnfinishedStoryLineIdList.Contains(storyLineInfoScNotify.CurStoryLineId))
		{
			storyLineInfoScNotify.UnfinishedStoryLineIdList.Add(storyLineInfoScNotify.CurStoryLineId);
		}
		GameData.StroyLineTrialAvatarDataData.TryGetValue(player.StoryLineManager.StoryLineData.CurStoryLineId, out StroyLineTrialAvatarDataExcel value);
		if (value != null)
		{
			storyLineInfoScNotify.TrialAvatarIdList.AddRange(value.InitTrialAvatarList.Select((int x) => (uint)x));
		}
		SetData(storyLineInfoScNotify);
	}
}
