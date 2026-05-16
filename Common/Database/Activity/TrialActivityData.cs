using System.Collections.Generic;
using March7thHoney.Proto;

namespace March7thHoney.Database.Activity;

public class TrialActivityData
{
	public List<TrialActivityResultData> Activities { get; set; } = new List<TrialActivityResultData>();

	public int CurTrialStageId { get; set; }

	public List<TrialActivityInfo> ToProto()
	{
		List<TrialActivityInfo> list = new List<TrialActivityInfo>();
		foreach (TrialActivityResultData activity in Activities)
		{
			list.Add(new TrialActivityInfo
			{
				StageId = (uint)activity.StageId,
				TakenReward = activity.TakenReward
			});
		}
		return list;
	}
}
