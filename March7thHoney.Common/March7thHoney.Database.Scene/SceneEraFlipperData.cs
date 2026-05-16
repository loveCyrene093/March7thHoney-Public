using System.Collections.Generic;

namespace March7thHoney.Database.Scene;

public class SceneEraFlipperData
{
	public int CurRegionId { get; set; }

	public Dictionary<int, int> RegionState { get; set; } = new Dictionary<int, int>();
}
