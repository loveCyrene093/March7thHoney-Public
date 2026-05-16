using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data.Config.Task;
using Newtonsoft.Json.Linq;

namespace March7thHoney.Data.Config;

public class LevelInitSequeceConfigInfo
{
	public List<TaskConfigInfo> TaskList { get; set; } = new List<TaskConfigInfo>();

	public static LevelInitSequeceConfigInfo LoadFromJsonObject(JObject obj)
	{
		LevelInitSequeceConfigInfo levelInitSequeceConfigInfo = new LevelInitSequeceConfigInfo();
		if (obj.ContainsKey("TaskList"))
		{
			levelInitSequeceConfigInfo.TaskList = obj["TaskList"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)).ToList() ?? new List<TaskConfigInfo>();
		}
		return levelInitSequeceConfigInfo;
	}
}
