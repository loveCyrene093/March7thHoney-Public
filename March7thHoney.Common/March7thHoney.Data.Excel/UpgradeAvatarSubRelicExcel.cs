using System.Collections.Generic;
using March7thHoney.Enums.Avatar;
using March7thHoney.Enums.Item;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Excel;

[ResourceEntity("UpgradeAvatarSubRelic.json")]
public class UpgradeAvatarSubRelicExcel : ExcelResource
{
	[JsonProperty("GOBEGPKDLLF")]
	public uint RelicLevel { get; set; }

	[JsonProperty("COACLFEBBDA")]
	[JsonConverter(typeof(StringEnumConverter))]
	public UpgradeAvatarSubRelicTypeEnum SubType { get; set; }

	[JsonProperty("JLLLGAGBEMF")]
	[JsonConverter(typeof(StringEnumConverter))]
	public RarityEnum Rarity { get; set; }

	[JsonProperty("GEEKCAGBGMN")]
	[JsonConverter(typeof(StringEnumConverter))]
	public RelicTypeEnum Type { get; set; }

	[JsonProperty("PINMGEKOAKM")]
	public List<UpgradeAvatarSubAffixInfo> SubAffixes { get; set; } = new List<UpgradeAvatarSubAffixInfo>();

	public override int GetId()
	{
		return (int)SubType;
	}

	public override void Loaded()
	{
		GameData.UpgradeAvatarSubRelicData.TryAdd(SubType, new Dictionary<RarityEnum, Dictionary<uint, Dictionary<RelicTypeEnum, UpgradeAvatarSubRelicExcel>>>());
		GameData.UpgradeAvatarSubRelicData[SubType].TryAdd(Rarity, new Dictionary<uint, Dictionary<RelicTypeEnum, UpgradeAvatarSubRelicExcel>>());
		GameData.UpgradeAvatarSubRelicData[SubType][Rarity].TryAdd(RelicLevel, new Dictionary<RelicTypeEnum, UpgradeAvatarSubRelicExcel>());
		GameData.UpgradeAvatarSubRelicData[SubType][Rarity][RelicLevel].TryAdd(Type, this);
	}
}
