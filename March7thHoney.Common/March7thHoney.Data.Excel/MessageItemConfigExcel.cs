using System.Collections.Generic;
using Newtonsoft.Json;

namespace March7thHoney.Data.Excel;

[ResourceEntity("MessageItemConfig.json")]
public class MessageItemConfigExcel : ExcelResource
{
	public int ID { get; set; }

	public List<int> NextItemIDList { get; set; } = new List<int>();

	public int SectionID { get; set; }

	[JsonIgnore]
	public int GroupID { get; set; }

	public override int GetId()
	{
		return ID;
	}

	public override void Loaded()
	{
		GameData.MessageItemConfigData.Add(ID, this);
	}

	public override void AfterAllDone()
	{
		if (GameData.MessageSectionConfigData.TryGetValue(SectionID, out MessageSectionConfigExcel value))
		{
			value.Items.Add(this);
			GroupID = value.GroupID;
		}
	}
}
