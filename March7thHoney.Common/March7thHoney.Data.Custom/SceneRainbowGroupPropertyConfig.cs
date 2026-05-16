using System.Collections.Generic;

namespace March7thHoney.Data.Custom;

public class SceneRainbowGroupPropertyConfig
{
	public Dictionary<int, Dictionary<int, Dictionary<string, Dictionary<int, RainbowGroupPropertyInfo>>>> FloorProperty { get; set; } = new Dictionary<int, Dictionary<int, Dictionary<string, Dictionary<int, RainbowGroupPropertyInfo>>>>();
}
