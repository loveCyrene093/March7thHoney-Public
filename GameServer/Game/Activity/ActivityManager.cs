using System.Collections.Generic;
using March7thHoney.Data;
using March7thHoney.Data.Custom;
using March7thHoney.Database;
using March7thHoney.Database.Activity;
using March7thHoney.GameServer.Game.Activity.Activities;
using March7thHoney.GameServer.Game.Activity.Activities.DiceCombat;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.Activity;

public class ActivityManager : BasePlayerManager
{
	public ActivityData Data { get; set; }

	public TrialActivityInstance? TrialActivityInstance { get; set; }

	public DiceCombatActivityInstance DiceCombat { get; set; }

	public ActivityManager(PlayerInstance player)
		: base(player)
	{
		Data = DatabaseHelper.Instance.GetInstanceOrCreateNew<ActivityData>(player.Uid);
		if (Data.TrialActivityData.CurTrialStageId != 0)
		{
			TrialActivityInstance = new TrialActivityInstance(this);
		}
		DiceCombat = new DiceCombatActivityInstance(this);
	}

	public List<March7thHoney.Proto.ActivityScheduleData> ToProto()
	{
		List<March7thHoney.Proto.ActivityScheduleData> list = new List<March7thHoney.Proto.ActivityScheduleData>();
		foreach (March7thHoney.Data.Custom.ActivityScheduleData scheduleDatum in GameData.ActivityConfig.ScheduleData)
		{
			list.Add(new March7thHoney.Proto.ActivityScheduleData
			{
				ActivityId = (uint)scheduleDatum.ActivityId,
				BeginTime = scheduleDatum.BeginTime,
				EndTime = scheduleDatum.EndTime,
				PanelId = (uint)scheduleDatum.PanelId
			});
		}
		return list;
	}
}
