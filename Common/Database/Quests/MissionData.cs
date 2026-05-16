using System.Collections.Generic;
using March7thHoney.Enums.Mission;
using March7thHoney.Util;
using SqlSugar;

namespace March7thHoney.Database.Quests;

[SugarTable("Mission")]
public class MissionData : BaseDatabaseDataHelper
{
	[SugarColumn(IsJson = true, ColumnDataType = "TEXT")]
	public Dictionary<int, Dictionary<int, MissionInfo>> MissionInfo { get; set; } = new Dictionary<int, Dictionary<int, MissionInfo>>();

	[SugarColumn(IsJson = true)]
	public Dictionary<int, MissionPhaseEnum> MainMissionInfo { get; set; } = new Dictionary<int, MissionPhaseEnum>();

	[SugarColumn(IsJson = true, ColumnDataType = "text")]
	public List<int> FinishedSubMissionIds { get; set; } = new List<int>();

	[SugarColumn(IsJson = true, ColumnDataType = "text")]
	public List<int> RunningSubMissionIds { get; set; } = new List<int>();

	[SugarColumn(IsJson = true)]
	public List<int> FinishedMainMissionIds { get; set; } = new List<int>();

	[SugarColumn(IsJson = true)]
	public List<int> RunningMainMissionIds { get; set; } = new List<int>();

	[SugarColumn(IsJson = true)]
	public Dictionary<int, int> SubMissionProgressDict { get; set; } = new Dictionary<int, int>();

	public int TrackingMainMissionId { get; set; }

	public MissionPhaseEnum GetMainMissionStatus(int missionId)
	{
		if (FinishedMainMissionIds.Contains(missionId))
		{
			return MissionPhaseEnum.Finish;
		}
		if (RunningMainMissionIds.Contains(missionId))
		{
			return MissionPhaseEnum.Accept;
		}
		return MissionPhaseEnum.None;
	}

	public MissionPhaseEnum GetSubMissionStatus(int missionId)
	{
		if (FinishedSubMissionIds.Contains(missionId))
		{
			return MissionPhaseEnum.Finish;
		}
		if (RunningSubMissionIds.Contains(missionId))
		{
			return MissionPhaseEnum.Accept;
		}
		return MissionPhaseEnum.None;
	}

	public void SetMainMissionStatus(int missionId, MissionPhaseEnum phase)
	{
		switch (phase)
		{
		case MissionPhaseEnum.Finish:
			FinishedMainMissionIds.SafeAdd(missionId);
			RunningMainMissionIds.Remove(missionId);
			break;
		case MissionPhaseEnum.Accept:
			FinishedMainMissionIds.Remove(missionId);
			RunningMainMissionIds.SafeAdd(missionId);
			break;
		default:
			FinishedMainMissionIds.Remove(missionId);
			RunningMainMissionIds.Remove(missionId);
			break;
		}
	}

	public void SetSubMissionStatus(int missionId, MissionPhaseEnum phase)
	{
		switch (phase)
		{
		case MissionPhaseEnum.Finish:
			FinishedSubMissionIds.SafeAdd(missionId);
			RunningSubMissionIds.Remove(missionId);
			break;
		case MissionPhaseEnum.Accept:
			FinishedSubMissionIds.Remove(missionId);
			RunningSubMissionIds.SafeAdd(missionId);
			break;
		default:
			FinishedSubMissionIds.Remove(missionId);
			RunningSubMissionIds.Remove(missionId);
			break;
		}
	}

	public void MoveFromOld()
	{
		foreach (KeyValuePair<int, Dictionary<int, MissionInfo>> item in MissionInfo)
		{
			foreach (KeyValuePair<int, MissionInfo> item2 in item.Value)
			{
				if (item2.Value.Status == MissionPhaseEnum.Finish)
				{
					FinishedSubMissionIds.SafeAdd(item2.Key);
				}
				else if (item2.Value.Status == MissionPhaseEnum.Accept)
				{
					RunningSubMissionIds.SafeAdd(item2.Key);
				}
			}
		}
		MissionInfo.Clear();
		foreach (KeyValuePair<int, MissionPhaseEnum> item3 in MainMissionInfo)
		{
			if (item3.Value == MissionPhaseEnum.Finish)
			{
				FinishedMainMissionIds.SafeAdd(item3.Key);
			}
			else if (item3.Value == MissionPhaseEnum.Accept)
			{
				RunningMainMissionIds.SafeAdd(item3.Key);
			}
		}
		MainMissionInfo.Clear();
	}
}
