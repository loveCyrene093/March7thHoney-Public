using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Mission;

[Opcode(1249)]
public class HandlerStarPerformanceRelayCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		StarPerformanceRelayCsReq starPerformanceRelayCsReq = StarPerformanceRelayCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		if (player == null)
		{
			return;
		}
		if (player.MissionManager != null)
		{
			await player.MissionManager.HandleAllFinishType((starPerformanceRelayCsReq.PerformanceId == 0) ? null : ((object)starPerformanceRelayCsReq.PerformanceId));
		}
		if (player.StoryLineManager != null)
		{
			await player.StoryLineManager.CheckIfFinishStoryLine();
			if (player.StoryLineManager.StoryLineData.CurStoryLineId == 0)
			{
				await player.StoryLineManager.CheckIfEnterStoryLine();
			}
			else
			{
				await player.StoryLineManager.LeaveStoryLine(tp: true);
			}
		}
		player.SceneInstance?.SyncGroupInfo();
		if (player.QuestManager != null)
		{
			await player.QuestManager.SyncQuest();
		}
	}
}
