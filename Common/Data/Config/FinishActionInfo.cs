using System.Collections.Generic;
using March7thHoney.Enums.Mission;
using March7thHoney.Util;
using Newtonsoft.Json;

namespace March7thHoney.Data.Config;

public class FinishActionInfo
{
	[JsonConverter(typeof(SafeStringEnumConverter<FinishActionTypeEnum>))]
	public FinishActionTypeEnum FinishActionType { get; set; }

	public List<int> FinishActionPara { get; set; } = new List<int>();

	public List<string> FinishActionParaString { get; set; } = new List<string>();
}
