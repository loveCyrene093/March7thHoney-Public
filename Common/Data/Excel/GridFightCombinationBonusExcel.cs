using System.Collections.Generic;

namespace March7thHoney.Data.Excel;

[ResourceEntity("GridFightCombinationBonus.json")]
public class GridFightCombinationBonusExcel : ExcelResource
{
	public uint BonusID { get; set; }

	public List<uint> CombinationBonusList { get; set; } = new List<uint>();

	public List<uint> BonusNumberList { get; set; } = new List<uint>();

	public override int GetId()
	{
		return (int)BonusID;
	}

	public override void Loaded()
	{
		GameData.GridFightCombinationBonusData.TryAdd(BonusID, this);
	}
}
