using System.Collections.Generic;

namespace March7thHoney.Data.Excel;

[ResourceEntity("StroyLineTrialAvatarData.json")]
public class StroyLineTrialAvatarDataExcel : ExcelResource
{
	public int StoryLineID { get; set; }

	public List<int> TrialAvatarList { get; set; } = new List<int>();

	public List<int> InitTrialAvatarList { get; set; } = new List<int>();

	public int CaptainAvatarID { get; set; }

	public override int GetId()
	{
		return StoryLineID;
	}

	public override void Loaded()
	{
		GameData.StroyLineTrialAvatarDataData[StoryLineID] = this;
	}
}
