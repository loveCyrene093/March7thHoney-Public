using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data;
using March7thHoney.Data.Config.Scene;
using SqlSugar;

namespace March7thHoney.Database.Scene;

[SugarTable("Scene")]
public class SceneData : BaseDatabaseDataHelper
{
	[SugarColumn(IsJson = true, ColumnDataType = "TEXT")]
	public Dictionary<int, Dictionary<int, List<ScenePropData>>> ScenePropData { get; set; } = new Dictionary<int, Dictionary<int, List<ScenePropData>>>();

	[SugarColumn(IsJson = true)]
	public Dictionary<int, List<int>> UnlockSectionIdList { get; set; } = new Dictionary<int, List<int>>();

	[SugarColumn(IsJson = true)]
	public Dictionary<int, Dictionary<int, string>> CustomSaveData { get; set; } = new Dictionary<int, Dictionary<int, string>>();

	[SugarColumn(IsJson = true)]
	public Dictionary<int, Dictionary<string, int>> FloorSavedData { get; set; } = new Dictionary<int, Dictionary<string, int>>();

	[SugarColumn(IsJson = true, ColumnDataType = "TEXT")]
	public Dictionary<int, Dictionary<int, Dictionary<int, ScenePropTimelineData>>> PropTimelineData { get; set; } = new Dictionary<int, Dictionary<int, Dictionary<int, ScenePropTimelineData>>>();

	[SugarColumn(IsJson = true, ColumnDataType = "TEXT")]
	public Dictionary<int, List<SceneMarkedChestData>> MarkedChestData { get; set; } = new Dictionary<int, List<SceneMarkedChestData>>();

	[SugarColumn(IsJson = true, ColumnDataType = "TEXT")]
	public Dictionary<int, Dictionary<int, Dictionary<string, int>>> GroupPropertyData { get; set; } = new Dictionary<int, Dictionary<int, Dictionary<string, int>>>();

	[SugarColumn(IsJson = true, ColumnDataType = "TEXT")]
	public SceneEraFlipperData EraFlipperData { get; set; } = new SceneEraFlipperData();

	[SugarColumn(IsJson = true, ColumnDataType = "TEXT")]
	public SceneRotatableRegionData RotatableRegionData { get; set; } = new SceneRotatableRegionData();

	[SugarColumn(IsJson = true, ColumnDataType = "TEXT")]
	public Dictionary<int, int> FloorTargetPuzzleGroupData { get; set; } = new Dictionary<int, int>();

	[SugarColumn(IsJson = true, ColumnDataType = "TEXT")]
	public Dictionary<int, SwitchHandInfo> SwitchHandData { get; set; } = new Dictionary<int, SwitchHandInfo>();

	public int GetFloorSavedValue(int floorId, string key)
	{
		if (FloorSavedData.TryGetValue(floorId, out Dictionary<string, int> value) && value.TryGetValue(key, out var value2))
		{
			return value2;
		}
		FloorInfo floorInfo = GameData.GetFloorInfo(floorId);
		if (floorInfo == null)
		{
			return 0;
		}
		return floorInfo.FloorSavedValue.FirstOrDefault((FloorSavedValueInfo x) => x.Name == key)?.DefaultValue ?? 0;
	}

	public Dictionary<string, int> GetFloorSavedValues(int floorId)
	{
		FloorInfo floorInfo = GameData.GetFloorInfo(floorId);
		if (floorInfo == null)
		{
			return new Dictionary<string, int>();
		}
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		foreach (FloorSavedValueInfo item in floorInfo.FloorSavedValue)
		{
			dictionary[item.Name] = GetFloorSavedValue(floorId, item.Name);
		}
		return dictionary;
	}
}
