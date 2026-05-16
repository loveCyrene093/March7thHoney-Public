using System.Collections.Generic;

namespace March7thHoney.Data.Excel;

[ResourceEntity("TrainPartyAreaGoalConfig.json")]
public class TrainPartyAreaGoalConfigExcel : ExcelResource
{
	public int AreaID { get; set; }

	public int ID { get; set; }

	public List<int> StepGroupList { get; set; } = new List<int>();

	public override int GetId()
	{
		return ID;
	}

	public override void Loaded()
	{
		GameData.TrainPartyAreaGoalConfigData.Add(ID, this);
	}
}
