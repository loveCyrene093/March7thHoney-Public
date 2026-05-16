using System.Collections.Generic;
using March7thHoney.Enums.GridFight;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Excel;

[ResourceEntity("GridFightAugment.json")]
public class GridFightAugmentExcel : ExcelResource
{
	public uint ID { get; set; }

	public uint CategoryID { get; set; }

	public List<string> AugmentSavedValueList { get; set; } = new List<string>();

	[JsonConverter(typeof(StringEnumConverter))]
	public GridFightAugmentQualityEnum Quality { get; set; }

	public override int GetId()
	{
		return (int)ID;
	}

	public override void Loaded()
	{
		GameData.GridFightAugmentData.TryAdd(ID, this);
	}
}
