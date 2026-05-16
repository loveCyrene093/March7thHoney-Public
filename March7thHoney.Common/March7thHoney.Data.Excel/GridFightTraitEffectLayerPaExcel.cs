using System.Collections.Generic;
using March7thHoney.Data.Config;

namespace March7thHoney.Data.Excel;

[ResourceEntity("GridFightTraitEffectLayerPa.json")]
public class GridFightTraitEffectLayerPaExcel : ExcelResource
{
	public uint ID { get; set; }

	public uint Layer { get; set; }

	public List<FixedValueInfo<double>> EffectParamList { get; set; } = new List<FixedValueInfo<double>>();

	public override int GetId()
	{
		return (int)ID;
	}

	public override void Loaded()
	{
		GameData.GridFightTraitEffectLayerPaData.TryAdd(ID, new Dictionary<uint, GridFightTraitEffectLayerPaExcel>());
		GameData.GridFightTraitEffectLayerPaData[ID][Layer] = this;
	}
}
