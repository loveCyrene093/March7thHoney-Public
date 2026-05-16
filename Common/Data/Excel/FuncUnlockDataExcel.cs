using System.Collections.Generic;

namespace March7thHoney.Data.Excel;

[ResourceEntity("FuncUnlockData.json")]
public class FuncUnlockDataExcel : ExcelResource
{
	public int UnlockID { get; set; }

	public List<FuncUnlockCondition> Conditions { get; set; } = new List<FuncUnlockCondition>();

	public override int GetId()
	{
		return UnlockID;
	}

	public override void Loaded()
	{
		GameData.FuncUnlockDataData[UnlockID] = this;
	}
}
