using System.Collections.Generic;
using March7thHoney.Enums.RogueMagic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueMagicScepter.json")]
public class RogueMagicScepterExcel : ExcelResource
{
	public int ScepterID { get; set; }

	public int ScepterLevel { get; set; }

	public List<LockMagicUnitInfo> LockMagicUnit { get; set; } = new List<LockMagicUnitInfo>();

	public Dictionary<RogueMagicMountTypeEnum, int> TrenchCount { get; set; } = new Dictionary<RogueMagicMountTypeEnum, int>();

	public int UnlockID { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public RogueMagicScepterFuncTypeEnum FuncType { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public RogueMagicStyleTypeEnum StyleType { get; set; }

	public int StaffMazeBuffID { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public RogueMagicRangeTypeEnum LimitRangeType { get; set; }

	[JsonProperty(ItemConverterType = typeof(StringEnumConverter))]
	public List<RogueMagicEffectTypeEnum> EffectTypeList { get; set; } = new List<RogueMagicEffectTypeEnum>();

	public override int GetId()
	{
		return ScepterID * 100 + ScepterLevel;
	}

	public override void Loaded()
	{
		GameData.RogueMagicScepterData.Add(GetId(), this);
	}
}
