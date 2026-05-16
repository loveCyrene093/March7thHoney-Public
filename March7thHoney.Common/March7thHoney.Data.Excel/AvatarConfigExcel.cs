using System.Collections.Generic;
using March7thHoney.Enums.Avatar;
using March7thHoney.Enums.Item;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Excel;

[ResourceEntity("AvatarConfig.json,AvatarConfigTrial.json,AvatarConfigLD.json", true)]
public class AvatarConfigExcel : ExcelResource
{
	[JsonIgnore]
	public Dictionary<int, List<AvatarSkillTreeConfigExcel>> DefaultSkillTree { get; set; } = new Dictionary<int, List<AvatarSkillTreeConfigExcel>>();

	[JsonIgnore]
	public string? Name { get; set; }

	[JsonIgnore]
	public Dictionary<int, List<AvatarSkillTreeConfigExcel>> SkillTree { get; set; } = new Dictionary<int, List<AvatarSkillTreeConfigExcel>>();

	public int AvatarID { get; set; }

	public int AdventurePlayerID { get; set; }

	public HashName AvatarName { get; set; } = new HashName();

	public int ExpGroup { get; set; }

	public int MaxPromotion { get; set; }

	public int MaxRank { get; set; }

	public List<int> RankIDList { get; set; } = new List<int>();

	public string? JsonPath { get; set; } = "";

	[JsonConverter(typeof(StringEnumConverter))]
	public RarityEnum Rarity { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public DamageTypeEnum DamageType { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public AvatarBaseTypeEnum AvatarBaseType { get; set; }

	public override int GetId()
	{
		return AvatarID;
	}

	public override void Loaded()
	{
		if (!GameData.AvatarConfigData.ContainsKey(AvatarID))
		{
			GameData.AvatarConfigData.Add(AvatarID, this);
		}
		JsonPath = null;
	}
}
