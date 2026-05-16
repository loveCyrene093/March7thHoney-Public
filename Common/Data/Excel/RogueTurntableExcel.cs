using March7thHoney.Enums.Rogue;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueTurntable.json")]
public class RogueTurntableExcel : ExcelResource
{
	public int ParamGroupID { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public RogueTurntableRewardLevelEnum RewardLevel { get; set; }

	public int PrepareTime { get; set; }

	public override int GetId()
	{
		return (int)(ParamGroupID * 10 + RewardLevel);
	}

	public override void Loaded()
	{
		GameData.RogueTurntableData.Add(GetId(), this);
	}
}
