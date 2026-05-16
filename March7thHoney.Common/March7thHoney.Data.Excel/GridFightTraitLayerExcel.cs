using System.Collections.Generic;

namespace March7thHoney.Data.Excel;

[ResourceEntity("GridFightTraitLayer.json")]
public class GridFightTraitLayerExcel : ExcelResource
{
	public uint TraitID { get; set; }

	public uint Layer { get; set; }

	public uint MazebuffID { get; set; }

	public override int GetId()
	{
		return (int)TraitID;
	}

	public override void Loaded()
	{
		GameData.GridFightTraitLayerData.TryAdd(TraitID, new Dictionary<uint, GridFightTraitLayerExcel>());
		GameData.GridFightTraitLayerData[TraitID].TryAdd(Layer, this);
	}
}
