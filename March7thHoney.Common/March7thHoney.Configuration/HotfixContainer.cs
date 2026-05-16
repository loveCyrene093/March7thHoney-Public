using System.Collections.Generic;
using March7thHoney.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Configuration;

public class HotfixContainer
{
	[JsonConverter(typeof(StringEnumConverter))]
	public BaseRegionEnum Region { get; set; }

	public Dictionary<string, DownloadUrlConfig> HotfixData { get; set; } = new Dictionary<string, DownloadUrlConfig>();
}
