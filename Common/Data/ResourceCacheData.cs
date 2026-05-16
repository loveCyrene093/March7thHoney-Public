using System.Collections.Generic;

namespace March7thHoney.Data;

public class ResourceCacheData
{
	public Dictionary<string, byte[]> GameDataValues { get; set; } = new Dictionary<string, byte[]>();
}
