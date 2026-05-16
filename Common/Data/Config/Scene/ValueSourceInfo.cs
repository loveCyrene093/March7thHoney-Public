using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace March7thHoney.Data.Config.Scene;

public class ValueSourceInfo
{
	public List<JObject> Values { get; set; } = new List<JObject>();
}
