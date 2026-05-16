using System.Collections.Generic;

namespace March7thHoney.Data.Config;

public class MissionInfo
{
	public int MainMissionID { get; set; }

	public List<int> StartSubMissionList { get; set; } = new List<int>();

	public List<int> FinishSubMissionList { get; set; } = new List<int>();

	public List<SubMissionInfo> SubMissionList { get; set; } = new List<SubMissionInfo>();

	public List<CustomValueInfo> MissionCustomValueList { get; set; } = new List<CustomValueInfo>();
}
