using System.Collections.Generic;
using March7thHoney.Enums.Avatar;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Excel;

[ResourceEntity("MultiplePathAvatarConfig.json")]
public class MultiplePathAvatarConfigExcel : ExcelResource
{
	public List<Condition> UnlockConditions { get; set; } = new List<Condition>();

	public string ChangeConfigPath { get; set; } = "";

	[JsonConverter(typeof(StringEnumConverter))]
	public GenderTypeEnum Gender { get; set; }

	public int AvatarID { get; set; }

	public int BaseAvatarID { get; set; }

	public override int GetId()
	{
		return AvatarID;
	}

	public override void Loaded()
	{
		GameData.MultiplePathAvatarConfigData.Add(AvatarID, this);
	}
}
