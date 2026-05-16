using System.Collections.Generic;

namespace March7thHoney.Data.Excel;

[ResourceEntity("SpecialAvatarRelic.json")]
public class SpecialAvatarRelicExcel : ExcelResource
{
	public int RelicPropertyType { get; set; }

	public List<SpecialAvatarRelicInfo> RelicIDList { get; set; } = new List<SpecialAvatarRelicInfo>();

	public override int GetId()
	{
		return RelicPropertyType;
	}

	public override void Loaded()
	{
		GameData.SpecialAvatarRelicData[GetId()] = this;
	}
}
