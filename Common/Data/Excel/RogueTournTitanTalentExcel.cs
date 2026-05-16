using System.Collections.Generic;
using March7thHoney.Enums.TournRogue;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueTournTitanTalent.json")]
public class RogueTournTitanTalentExcel : ExcelResource
{
	public int ID { get; set; }

	public int PreID { get; set; }

	public int Level { get; set; }

	public List<MappingInfoItem> Cost { get; set; } = new List<MappingInfoItem>();

	[JsonConverter(typeof(StringEnumConverter))]
	public RogueTitanTypeEnum RogueTitanType { get; set; }

	public override int GetId()
	{
		return ID;
	}

	public override void Loaded()
	{
		GameData.RogueTournTitanTalentData.Add(ID, this);
	}
}
