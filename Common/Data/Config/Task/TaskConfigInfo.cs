using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace March7thHoney.Data.Config.Task;

public class TaskConfigInfo
{
	public string Type { get; set; } = "";

	public bool TaskEnabled { get; set; }

	public static TaskConfigInfo LoadFromJsonObject(JObject json)
	{
		string text = json["Type"]?.Value<string>() ?? "";
		if (string.IsNullOrEmpty(text))
		{
			return new TaskConfigInfo();
		}
		string text2 = text.Replace("RPG.GameCore.", "");
		Type type = System.Type.GetType("March7thHoney.Data.Config.Task." + text2);
		switch (text2)
		{
		case "PredicateTaskList":
		{
			TaskConfigInfo taskConfigInfo2 = PredicateTaskList.LoadFromJsonObject(json);
			taskConfigInfo2.Type = text;
			return taskConfigInfo2;
		}
		case "PropSetupUITrigger":
		{
			TaskConfigInfo taskConfigInfo = PropSetupUITrigger.LoadFromJsonObject(json);
			taskConfigInfo.Type = text;
			return taskConfigInfo;
		}
		case "PropStateExecute":
		{
			TaskConfigInfo taskConfigInfo11 = PropStateExecute.LoadFromJsonObject(json);
			taskConfigInfo11.Type = text;
			return taskConfigInfo11;
		}
		case "AddMazeBuff":
		{
			TaskConfigInfo taskConfigInfo10 = AddMazeBuff.LoadFromJsonObject(json);
			taskConfigInfo10.Type = text;
			return taskConfigInfo10;
		}
		case "RemoveMazeBuff":
		{
			TaskConfigInfo taskConfigInfo9 = RemoveMazeBuff.LoadFromJsonObject(json);
			taskConfigInfo9.Type = text;
			return taskConfigInfo9;
		}
		case "RefreshMazeBuffTime":
		{
			TaskConfigInfo taskConfigInfo8 = RefreshMazeBuffTime.LoadFromJsonObject(json);
			taskConfigInfo8.Type = text;
			return taskConfigInfo8;
		}
		case "AdventureFireProjectile":
		{
			TaskConfigInfo taskConfigInfo7 = AdventureFireProjectile.LoadFromJsonObject(json);
			taskConfigInfo7.Type = text;
			return taskConfigInfo7;
		}
		case "NewAdventureFireProjectile":
		{
			TaskConfigInfo taskConfigInfo6 = AdventureFireProjectile.LoadFromJsonObject(json);
			taskConfigInfo6.Type = text;
			return taskConfigInfo6;
		}
		case "AdventureTriggerAttack":
		{
			TaskConfigInfo taskConfigInfo5 = AdventureTriggerAttack.LoadFromJsonObject(json);
			taskConfigInfo5.Type = text;
			return taskConfigInfo5;
		}
		case "AddAdventureModifier":
		{
			TaskConfigInfo taskConfigInfo4 = AddAdventureModifier.LoadFromJsonObject(json);
			taskConfigInfo4.Type = text;
			return taskConfigInfo4;
		}
		case "RemoveAdventureModifier":
		{
			TaskConfigInfo taskConfigInfo3 = RemoveAdventureModifier.LoadFromJsonObject(json);
			taskConfigInfo3.Type = text;
			return taskConfigInfo3;
		}
		default:
			if (type != null)
			{
				TaskConfigInfo obj = (TaskConfigInfo)json.ToObject(type);
				obj.Type = text;
				return obj;
			}
			return JsonConvert.DeserializeObject<TaskConfigInfo>(json.ToString());
		}
	}
}
