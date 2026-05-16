using System.Collections.Generic;
using March7thHoney.Enums.GridFight;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Excel;

[ResourceEntity("GridFightEquipment.json")]
public class GridFightEquipmentExcel : ExcelResource
{
	public uint ID { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public GridFightEquipCategoryEnum EquipCategory { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public GridFightEquipDressTypeEnum DressRule { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public GridFightEquipFuncTypeEnum EquipFunc { get; set; }

	public List<uint> EquipFuncParamList { get; set; } = new List<uint>();

	public List<uint> DressRuleParamList { get; set; } = new List<uint>();

	public override int GetId()
	{
		return (int)ID;
	}

	public override void Loaded()
	{
		GameData.GridFightEquipmentData.TryAdd(ID, this);
	}
}
