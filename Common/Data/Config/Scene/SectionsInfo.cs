using System.Collections.Generic;

namespace March7thHoney.Data.Config.Scene;

public class SectionsInfo
{
	public int ID { get; set; }

	public int MapLayerID { get; set; }

	public bool IsRect { get; set; }

	public List<int> Indices { get; set; } = new List<int>();
}
