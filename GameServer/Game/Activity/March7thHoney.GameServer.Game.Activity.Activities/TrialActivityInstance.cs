using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Activity;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Activity;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.Activity.Activities;

public class TrialActivityInstance : BaseActivityInstance
{
	public TrialActivityData Data { get; set; }

	public TrialActivityInstance(ActivityManager manager)
		: base(manager)
	{
		Data = base.ActivityManager.Data.TrialActivityData;
	}

	public async ValueTask StartActivity(int stageId)
	{
		PlayerInstance player = base.ActivityManager.Player;
		await player.LineupManager.DestroyExtraLineup(ExtraLineupType.LineupStageTrial);
		GameData.AvatarDemoConfigData.TryGetValue(stageId, out AvatarDemoConfigExcel value);
		if (value != null)
		{
			Data.CurTrialStageId = stageId;
			player.LineupManager.SetExtraLineup(ExtraLineupType.LineupStageTrial, value.TrialAvatarList.ToList(), refresh: true);
			await player.EnterScene(value.MapEntranceID, 0, sendPacket: true);
		}
		await player.SendPacket(new PacketStartTrialActivityScRsp((uint)stageId));
	}

	public async ValueTask EndActivity(TrialActivityStatus status = TrialActivityStatus.None)
	{
		PlayerInstance player = base.ActivityManager.Player;
		await player.LineupManager.DestroyExtraLineup(ExtraLineupType.LineupStageTrial);
		player.LineupManager.LineupData.CurExtraLineup = -1;
		await player.EnterScene(2000101, 0, sendPacket: true);
		if (status == TrialActivityStatus.Finish)
		{
			Data.Activities.Add(new TrialActivityResultData
			{
				StageId = Data.CurTrialStageId
			});
			await player.SendPacket(new PacketCurTrialActivityScNotify((uint)Data.CurTrialStageId, status));
		}
		Data.CurTrialStageId = 0;
	}
}
