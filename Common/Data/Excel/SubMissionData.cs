using March7thHoney.Data.Config;

namespace March7thHoney.Data.Excel;

public class SubMissionData(int missionId)
{
	public int MissionId { get; set; } = missionId;

	public int MainMissionId { get; set; }

	public MissionInfo? MainMissionInfo { get; set; }

	public SubMissionInfo? SubMissionInfo { get; set; }

	public LevelGraphConfigInfo? SubMissionTaskInfo { get; set; }
}
