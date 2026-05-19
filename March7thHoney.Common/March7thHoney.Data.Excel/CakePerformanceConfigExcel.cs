using System.Collections.Generic;

namespace March7thHoney.Data.Excel;

[ResourceEntity("CakePerformanceConfig.json")]
public class CakePerformanceConfigExcel : ExcelResource
{
	public int ID { get; set; }

	public int QuestID { get; set; }

	public List<int> ActorsList { get; set; } = new List<int>();

	public override int GetId()
	{
		return ID;
	}

	public override void Loaded()
	{
		GameData.CakePerformanceConfigData[ID] = this;
	}
}
