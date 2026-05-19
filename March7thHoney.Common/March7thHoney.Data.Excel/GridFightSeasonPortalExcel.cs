using System.Collections.Generic;

namespace March7thHoney.Data.Excel;

[ResourceEntity("GridFightSeasonPortal.json")]
public class GridFightSeasonPortalExcel : ExcelResource
{
	public uint PortalID { get; set; }

	public uint SeasonID { get; set; }

	public string ConditionJsonPath { get; set; } = string.Empty;

	public uint Ratio { get; set; }

	public override int GetId()
	{
		return (int)(SeasonID * 100000 + PortalID);
	}

	public override void Loaded()
	{
		if (!GameData.GridFightSeasonPortalData.TryGetValue(SeasonID, out List<uint> value))
		{
			value = new List<uint>();
			GameData.GridFightSeasonPortalData[SeasonID] = value;
		}
		if (!value.Contains(PortalID))
		{
			value.Add(PortalID);
		}
	}
}
