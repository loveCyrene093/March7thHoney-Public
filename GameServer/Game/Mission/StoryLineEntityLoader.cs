using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Config.Scene;
using March7thHoney.Data.Excel;
using March7thHoney.Enums.Scene;
using March7thHoney.GameServer.Game.Scene;
using March7thHoney.GameServer.Game.Scene.Entity;

namespace March7thHoney.GameServer.Game.Mission;

public class StoryLineEntityLoader : SceneEntityLoader
{
	public int DimensionId;

	public StoryLineEntityLoader(SceneInstance scene)
		: base(scene)
	{
	}

	public override async ValueTask LoadEntity()
	{
		if (base.Scene.IsLoaded)
		{
			return;
		}
		int num = base.Scene.Player.StoryLineManager?.StoryLineData.CurStoryLineId ?? 0;
		if (num == 0)
		{
			return;
		}
		GameData.StoryLineFloorDataData.TryGetValue(num, out Dictionary<int, StoryLineFloorDataExcel> value);
		if (value == null)
		{
			return;
		}
		value.TryGetValue(base.Scene.FloorInfo?.FloorID ?? 0, out var floorInfo);
		if (floorInfo == null)
		{
			floorInfo = new StoryLineFloorDataExcel
			{
				DimensionID = 0
			};
		}
		FloorDimensionInfo floorDimensionInfo = base.Scene.FloorInfo?.DimensionList.Find((FloorDimensionInfo d) => d.ID == floorInfo.DimensionID);
		if (floorDimensionInfo == null)
		{
			return;
		}
		DimensionId = floorDimensionInfo.ID;
		base.LoadGroups.AddRange(floorDimensionInfo.GroupIDList);
		foreach (GroupInfo item in base.Scene.FloorInfo?.Groups.Values)
		{
			if (item.LoadSide != GroupLoadSideEnum.Client && !item.GroupName.Contains("TrainVisitor"))
			{
				await LoadGroup(item);
			}
		}
		base.Scene.IsLoaded = true;
	}

	public override async ValueTask<List<BaseGameEntity>?> LoadGroup(GroupInfo info, bool forceLoad = false)
	{
		if (!base.LoadGroups.Contains(info.Id))
		{
			return null;
		}
		return await base.LoadGroup(info, forceLoad);
	}
}
