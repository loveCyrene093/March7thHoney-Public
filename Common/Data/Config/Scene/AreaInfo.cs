using System.Collections.Generic;

namespace March7thHoney.Data.Config.Scene;

public class AreaInfo
{
	public int ID { get; set; }

	public MinimapVolumeInfo MinimapVolume { get; set; } = new MinimapVolumeInfo();

	public List<int> RegionIDList { get; set; } = new List<int>();

	public List<int> MapLayerList { get; set; } = new List<int>();
}
