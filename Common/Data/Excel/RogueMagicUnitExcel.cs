using System.Collections.Generic;
using March7thHoney.Enums.RogueMagic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueMagicUnit.json")]
public class RogueMagicUnitExcel : ExcelResource
{
	public int MagicUnitID { get; set; }

	public int MagicUnitLevel { get; set; }

	public RogueMagicUnitCategoryEnum MagicUnitCategory { get; set; }

	public RogueMagicMountTypeEnum MagicUnitType { get; set; }

	public int UnlockID { get; set; }

	public int MagicUnitMazeBuffID { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public RogueMagicStyleTypeEnum StyleType { get; set; }

	public List<int> ExtraEffectID { get; set; } = new List<int>();

	[JsonConverter(typeof(StringEnumConverter))]
	public RogueMagicScepterFuncTypeEnum FuncType { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public RogueMagicRangeTypeEnum LimitRange { get; set; }

	[JsonProperty(ItemConverterType = typeof(StringEnumConverter))]
	public List<RogueMagicRangeTypeEnum> AttachRangeTypeList { get; set; } = new List<RogueMagicRangeTypeEnum>();

	[JsonProperty(ItemConverterType = typeof(StringEnumConverter))]
	public List<RogueMagicEffectTypeEnum> EffectTypeList { get; set; } = new List<RogueMagicEffectTypeEnum>();

	[JsonConverter(typeof(StringEnumConverter))]
	public RogueMagicSpecialTypeEnum SpecialType { get; set; }

	public bool IsPassiveUnit { get; set; }

	public bool IsActiveUnit { get; set; }

	public override int GetId()
	{
		return MagicUnitID * 100 + MagicUnitLevel;
	}

	public override void Loaded()
	{
		GameData.RogueMagicUnitData.Add(GetId(), this);
	}
}
