using System.Collections.Generic;
using Newtonsoft.Json;

namespace March7thHoney.Data.Excel;

[ResourceEntity("MessageSectionConfig.json")]
public class MessageSectionConfigExcel : ExcelResource
{
	public int ID { get; set; }

	public List<int> StartMessageItemIDList { get; set; } = new List<int>();

	public bool IsPerformMessage { get; set; }

	public int MainMissionLink { get; set; }

	[JsonIgnore]
	public List<MessageItemConfigExcel> Items { get; set; } = new List<MessageItemConfigExcel>();

	[JsonIgnore]
	public int GroupID { get; set; }

	public override int GetId()
	{
		return ID;
	}

	public override void Loaded()
	{
		GameData.MessageSectionConfigData.Add(ID, this);
	}
}
