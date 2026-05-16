using System.Collections.Generic;

namespace March7thHoney.Data.Config.Scene;

public class MapInfo
{
	public List<AreaInfo> AreaList { get; set; } = new List<AreaInfo>();

	public List<int> MapLayerList { get; set; } = new List<int>();
}
