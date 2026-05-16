using System.Collections.Generic;
using Newtonsoft.Json;

namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueTournWorkbench.json")]
public class RogueTournWorkbenchExcel : ExcelResource
{
	public int WorkbenchID { get; set; }

	public List<int> FuncList { get; set; } = new List<int>();

	[JsonIgnore]
	public List<RogueTournWorkbenchFuncExcel> Funcs { get; set; } = new List<RogueTournWorkbenchFuncExcel>();

	public override int GetId()
	{
		return WorkbenchID;
	}

	public override void Loaded()
	{
		GameData.RogueTournWorkbenchData.Add(WorkbenchID, this);
	}

	public override void AfterAllDone()
	{
		foreach (int func in FuncList)
		{
			if (GameData.RogueTournWorkbenchFuncData.TryGetValue(func, out RogueTournWorkbenchFuncExcel value))
			{
				Funcs.Add(value);
			}
		}
	}
}
