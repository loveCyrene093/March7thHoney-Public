using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace March7thHoney.Data.Config;

public class LevelGraphConfigInfo
{
	public List<LevelInitSequeceConfigInfo> OnInitSequece { get; set; } = new List<LevelInitSequeceConfigInfo>();

	public List<LevelStartSequeceConfigInfo> OnStartSequece { get; set; } = new List<LevelStartSequeceConfigInfo>();

	public static LevelGraphConfigInfo LoadFromJsonObject(JObject obj)
	{
		LevelGraphConfigInfo levelGraphConfigInfo = new LevelGraphConfigInfo();
		if (obj.ContainsKey("OnInitSequece"))
		{
			levelGraphConfigInfo.OnInitSequece = obj["OnInitSequece"]?.Select((JToken x) => LevelInitSequeceConfigInfo.LoadFromJsonObject(x as JObject)).ToList() ?? new List<LevelInitSequeceConfigInfo>();
		}
		if (obj.ContainsKey("OnStartSequece"))
		{
			levelGraphConfigInfo.OnStartSequece = obj["OnStartSequece"]?.Select((JToken x) => LevelStartSequeceConfigInfo.LoadFromJsonObject(x as JObject)).ToList() ?? new List<LevelStartSequeceConfigInfo>();
		}
		return levelGraphConfigInfo;
	}
}
