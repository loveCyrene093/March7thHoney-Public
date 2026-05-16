using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace March7thHoney.Data.Config.Scene;

public class FloorDimensionInfo
{
	public int ID { get; set; }

	public List<DimensionSavedValues> SavedValues { get; set; } = new List<DimensionSavedValues>();

	public List<int> GroupIndexList { get; set; } = new List<int>();

	[JsonIgnore]
	public List<int> GroupIDList { get; set; } = new List<int>();

	public void OnLoad(FloorInfo floor)
	{
		foreach (DimensionSavedValues data in SavedValues)
		{
			if (!floor.FloorSavedValue.Any((FloorSavedValueInfo x) => x.Name == data.Name))
			{
				floor.FloorSavedValue.Add(new FloorSavedValueInfo
				{
					ID = data.ID,
					Name = data.Name,
					DefaultValue = data.DefaultValue
				});
			}
		}
		foreach (int groupIndex in GroupIndexList)
		{
			GroupIDList.Add(floor.GroupInstanceList[groupIndex].ID);
		}
	}
}
