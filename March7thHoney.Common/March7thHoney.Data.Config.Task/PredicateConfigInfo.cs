using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace March7thHoney.Data.Config.Task;

public class PredicateConfigInfo : TaskConfigInfo
{
	public bool Inverse { get; set; }

	public new static PredicateConfigInfo LoadFromJsonObject(JObject obj)
	{
		PredicateConfigInfo predicateConfigInfo = new PredicateConfigInfo();
		predicateConfigInfo.Type = obj["Type"].ToObject<string>();
		string text = predicateConfigInfo.Type.Replace("RPG.GameCore.", "");
		string typeName = "March7thHoney.Data.Config.Task." + text;
		if (!(text == "ByIsContainAdventureModifier"))
		{
			if (text == "ByAnd")
			{
				return ByAnd.LoadFromJsonObject(obj);
			}
			Type type = System.Type.GetType(typeName);
			if (type != null)
			{
				return (PredicateConfigInfo)obj.ToObject(type);
			}
			return JsonConvert.DeserializeObject<PredicateConfigInfo>(obj.ToString());
		}
		return ByIsContainAdventureModifier.LoadFromJsonObject(obj);
	}
}
