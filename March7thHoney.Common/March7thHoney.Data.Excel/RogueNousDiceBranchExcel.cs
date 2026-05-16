using System.Collections.Generic;

namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueNousDiceBranch.json")]
public class RogueNousDiceBranchExcel : ExcelResource
{
	public int BranchID { get; set; }

	public int DefaultUltraSurface { get; set; }

	public List<int> DefaultCommonSurfaceList { get; set; } = new List<int>();

	public override int GetId()
	{
		return BranchID;
	}

	public override void Loaded()
	{
		GameData.RogueNousDiceBranchData[BranchID] = this;
	}

	public List<int> GetDefaultSurfaceList()
	{
		List<int> list = new List<int>();
		list.Add(DefaultUltraSurface);
		list.AddRange(DefaultCommonSurfaceList);
		return list;
	}
}
