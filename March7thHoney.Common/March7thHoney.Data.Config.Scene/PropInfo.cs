using System.Collections.Generic;
using March7thHoney.Enums.Scene;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace March7thHoney.Data.Config.Scene;

public class PropInfo : PositionInfo
{
	[JsonIgnore]
	public bool CommonConsole;

	public int MappingInfoID { get; set; }

	public int AnchorGroupID { get; set; }

	public int AnchorID { get; set; }

	public int PropID { get; set; }

	public int EventID { get; set; }

	public int CocoonID { get; set; }

	public int ChestID { get; set; }

	public int FarmElementID { get; set; }

	public bool IsClientOnly { get; set; }

	public bool LoadOnInitial { get; set; } = true;

	public ValueSourceInfo? ValueSource { get; set; }

	public string? InitLevelGraph { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public PropStateEnum State { get; set; }

	[JsonIgnore]
	public Dictionary<int, List<int>> UnlockDoorID { get; set; } = new Dictionary<int, List<int>>();

	[JsonIgnore]
	public Dictionary<int, List<int>> UnlockControllerID { get; set; } = new Dictionary<int, List<int>>();

	[JsonIgnore]
	public bool IsLevelBtn { get; set; }

	public void Load(GroupInfo info)
	{
		if (ValueSource == null)
		{
			return;
		}
		if (base.Name.StartsWith("Button_") && ValueSource.Values.Find((JObject x) => x["Key"]?.ToString() == "AnchorName") != null)
		{
			IsLevelBtn = true;
		}
		foreach (JObject value2 in ValueSource.Values)
		{
			JToken jToken = value2["Key"];
			JToken jToken2 = value2["Value"];
			if (jToken2 == null || jToken == null)
			{
				continue;
			}
			if (jToken.ToString() == "ListenTriggerCustomString")
			{
				if (!info.PropTriggerCustomString.TryGetValue(jToken2.ToString(), out List<int> value))
				{
					value = new List<int>();
					info.PropTriggerCustomString.Add(jToken2.ToString(), value);
				}
				value.Add(base.ID);
			}
			else if (jToken.ToString().Contains("Door") || jToken.ToString().Contains("Bridge") || jToken.ToString().Contains("UnlockTarget") || jToken.ToString().Contains("Rootcontamination") || jToken.ToString().Contains("Portal"))
			{
				string[] array = jToken2.ToString().Split(',');
				if (array.Length >= 2 && int.TryParse(array[0], out var result) && int.TryParse(array[1], out var result2))
				{
					if (!UnlockDoorID.ContainsKey(result))
					{
						UnlockDoorID.Add(result, new List<int>());
					}
					UnlockDoorID[result].Add(result2);
				}
			}
			else
			{
				if (!jToken.ToString().Contains("Controller"))
				{
					continue;
				}
				string[] array2 = jToken2.ToString().Split(',');
				if (array2.Length >= 2 && int.TryParse(array2[0], out var result3) && int.TryParse(array2[1], out var result4))
				{
					if (!UnlockControllerID.ContainsKey(result3))
					{
						UnlockControllerID.Add(result3, new List<int>());
					}
					UnlockControllerID[result3].Add(result4);
				}
			}
		}
	}
}
