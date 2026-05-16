using System.Collections.Generic;

namespace March7thHoney.Data.Excel;

[ResourceEntity("ContentPackageConfig.json")]
public class ContentPackageConfigExcel : ExcelResource
{
	public int ContentID { get; set; }

	public List<int> MainMissionIDList { get; set; } = new List<int>();

	public int ActivityModuleID { get; set; }

	public int InitEntranceID { get; set; }

	public int AfterGuideEntranceID { get; set; }

	public override int GetId()
	{
		return ContentID;
	}

	public override void Loaded()
	{
		GameData.ContentPackageConfigData.Add(ContentID, this);
	}

	public bool TouchesFloor(int floorId)
	{
		int[] array = new int[2] { InitEntranceID, AfterGuideEntranceID };
		foreach (int num in array)
		{
			if (num != 0 && GameData.MapEntranceData.TryGetValue(num, out MapEntranceExcel value) && value.FloorID == floorId)
			{
				return true;
			}
		}
		return false;
	}
}
