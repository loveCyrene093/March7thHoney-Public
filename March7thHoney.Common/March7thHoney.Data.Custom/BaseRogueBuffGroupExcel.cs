using System.Collections.Generic;
using Newtonsoft.Json;

namespace March7thHoney.Data.Custom;

public class BaseRogueBuffGroupExcel : ExcelResource
{
	public int GroupId { get; set; }

	[JsonIgnore]
	public List<BaseRogueBuffExcel> BuffList { get; set; } = new List<BaseRogueBuffExcel>();

	[JsonIgnore]
	public bool IsLoaded { get; set; }

	public override int GetId()
	{
		return GroupId;
	}
}
