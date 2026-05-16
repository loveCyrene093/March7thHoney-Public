using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data.Config.Task;
using Newtonsoft.Json.Linq;

namespace March7thHoney.Data.Config;

public class LevelStartSequeceConfigInfo
{
	public List<TaskConfigInfo> TaskList { get; set; } = new List<TaskConfigInfo>();

	public bool IsLoop { get; set; }

	public int Order { get; set; }

	public static LevelStartSequeceConfigInfo LoadFromJsonObject(JObject obj)
	{
		LevelStartSequeceConfigInfo levelStartSequeceConfigInfo = new LevelStartSequeceConfigInfo();
		if (obj.ContainsKey("TaskList"))
		{
			levelStartSequeceConfigInfo.TaskList = obj["TaskList"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)).ToList() ?? new List<TaskConfigInfo>();
		}
		if (obj.ContainsKey("IsLoop"))
		{
			levelStartSequeceConfigInfo.IsLoop = obj["IsLoop"]?.Value<bool>() ?? false;
		}
		if (obj.ContainsKey("Order"))
		{
			levelStartSequeceConfigInfo.Order = obj["Order"]?.Value<int>() ?? 0;
		}
		return levelStartSequeceConfigInfo;
	}
}
