using System.Collections.Concurrent;
using System.Collections.Generic;
using March7thHoney.Enums.Scene;
using March7thHoney.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Config.Scene;

public class FloorInfo
{
	[JsonConverter(typeof(ConcurrentDictionaryConverter<int, PropInfo>))]
	public ConcurrentDictionary<int, PropInfo> CachedTeleports = new ConcurrentDictionary<int, PropInfo>();

	[JsonConverter(typeof(ConcurrentDictionaryConverter<int, GroupInfo>))]
	public ConcurrentDictionary<int, GroupInfo> Groups = new ConcurrentDictionary<int, GroupInfo>();

	[JsonIgnore]
	public bool Loaded;

	[JsonConverter(typeof(ConcurrentBagConverter<int>))]
	public ConcurrentBag<int> MapSections = new ConcurrentBag<int>();

	[JsonConverter(typeof(ConcurrentBagConverter<PropInfo>))]
	public ConcurrentBag<PropInfo> UnlockedCheckpoints = new ConcurrentBag<PropInfo>();

	public int FloorID { get; set; }

	public int StartGroupIndex { get; set; }

	public int StartAnchorID { get; set; }

	public string NavmapConfigPath { get; set; } = "";

	public List<FloorGroupInfo> GroupInstanceList { get; set; } = new List<FloorGroupInfo>();

	public List<FloorDimensionInfo> DimensionList { get; set; } = new List<FloorDimensionInfo>();

	[JsonProperty(ItemConverterType = typeof(StringEnumConverter))]
	public List<LevelFeatureTypeEnum> LevelFeatureModules { get; set; } = new List<LevelFeatureTypeEnum>();

	[JsonIgnore]
	public int StartGroupID { get; set; }

	[JsonIgnore]
	public List<FloorSavedValueInfo> FloorSavedValue { get; set; } = new List<FloorSavedValueInfo>();

	public AnchorInfo? GetAnchorInfo(int groupId, int anchorId)
	{
		Groups.TryGetValue(groupId, out GroupInfo value);
		return value?.AnchorList.Find((AnchorInfo info) => info.ID == anchorId);
	}

	public void OnLoad()
	{
		if (Loaded)
		{
			return;
		}
		StartGroupID = GroupInstanceList[StartGroupIndex].ID;
		foreach (FloorDimensionInfo dimension in DimensionList)
		{
			dimension.OnLoad(this);
		}
		foreach (GroupInfo value in Groups.Values)
		{
			foreach (PropInfo prop in value.PropList)
			{
				if (prop.AnchorID > 0)
				{
					CachedTeleports.TryAdd(prop.MappingInfoID, prop);
					UnlockedCheckpoints.Add(prop);
					prop.State = PropStateEnum.CheckPointEnable;
				}
				else if (!string.IsNullOrEmpty(prop.InitLevelGraph))
				{
					string initLevelGraph = prop.InitLevelGraph;
					if (!initLevelGraph.Contains("Maze_GroupProp_OpenTreasure_WhenMonsterDie") && initLevelGraph.Contains("Common_Console"))
					{
						prop.CommonConsole = true;
					}
					prop.ValueSource = null;
					prop.InitLevelGraph = null;
				}
			}
		}
		Loaded = true;
	}
}
