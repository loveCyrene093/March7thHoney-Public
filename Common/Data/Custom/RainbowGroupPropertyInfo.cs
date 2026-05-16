using System.Collections.Generic;

namespace March7thHoney.Data.Custom;

public class RainbowGroupPropertyInfo
{
	public List<RainbowActionInfo> PrivateActions { get; set; } = new List<RainbowActionInfo>();

	public List<RainbowActionInfo> Actions { get; set; } = new List<RainbowActionInfo>();
}
