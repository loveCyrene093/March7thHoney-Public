using System.Collections.Generic;
using March7thHoney.Enums.Mission;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Excel;

[ResourceEntity("HeartDialScript.json")]
public class HeartDialScriptExcel : ExcelResource
{
	public int ScriptID { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public HeartDialEmoTypeEnum DefaultEmoType { get; set; }

	[JsonProperty(ItemConverterType = typeof(StringEnumConverter))]
	public List<HeartDialStepTypeEnum> StepList { get; set; } = new List<HeartDialStepTypeEnum>();

	[JsonProperty(ItemConverterType = typeof(StringEnumConverter))]
	public List<HeartDialEmoTypeEnum> MissingEmoList { get; set; } = new List<HeartDialEmoTypeEnum>();

	public override int GetId()
	{
		return ScriptID;
	}

	public override void Loaded()
	{
		GameData.HeartDialScriptData[ScriptID] = this;
	}
}
