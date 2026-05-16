using March7thHoney.Enums.Task;

namespace March7thHoney.Data.Config.Task;

public class ByCompareSubMissionState : PredicateConfigInfo
{
	public int SubMissionID { get; set; }

	public SubMissionStateEnum SubMissionState { get; set; }

	public bool AllStoryLine { get; set; }
}
