using System.Collections.Generic;
using March7thHoney.Enums.Rogue;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueDLCBossDecay.json")]
public class RogueDLCBossDecayExcel : ExcelResource
{
	public int BossDecayID { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public BossDecayEffectTypeEnum EffectType { get; set; }

	public List<int> EffectParamList { get; set; } = new List<int>();

	public override int GetId()
	{
		return BossDecayID;
	}

	public override void Loaded()
	{
		GameData.RogueDLCBossDecayData.Add(GetId(), this);
	}
}
