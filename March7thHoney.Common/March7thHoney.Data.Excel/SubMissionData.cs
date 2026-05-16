using March7thHoney.Data.Config;

namespace March7thHoney.Data.Excel;

public class SubMissionData
{
	public int MissionId { get; set; }

	public int MainMissionId { get; set; }

	public MissionInfo? MainMissionInfo { get; set; }

	public SubMissionInfo? SubMissionInfo { get; set; }

	public LevelGraphConfigInfo? SubMissionTaskInfo { get; set; }

	public SubMissionData(int missionId)
	{
		MissionId = missionId;
		base._002Ector();
	}
}
