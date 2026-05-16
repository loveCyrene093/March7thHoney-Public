using System.Collections.Generic;
using March7thHoney.Enums.Rogue;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Excel;

[ResourceEntity("DialogueDynamicContent.json")]
public class DialogueDynamicContentExcel : ExcelResource
{
	public int DynamicContentID { get; set; }

	public int ArgID { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public DialogueDynamicParamTypeEnum DynamicParamType { get; set; }

	public List<int> DynamicParamList { get; set; } = new List<int>();

	public override int GetId()
	{
		return DynamicContentID;
	}

	public override void Loaded()
	{
		if (GameData.DialogueDynamicContentData.TryGetValue(DynamicContentID, out Dictionary<int, DialogueDynamicContentExcel> value))
		{
			value.Add(ArgID, this);
			return;
		}
		GameData.DialogueDynamicContentData.Add(DynamicContentID, new Dictionary<int, DialogueDynamicContentExcel> { { ArgID, this } });
	}
}
