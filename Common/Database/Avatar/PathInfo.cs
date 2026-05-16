using System.Collections.Generic;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Inventory;

namespace March7thHoney.Database.Avatar;

public class PathInfo(int pathId)
{
	public int PathId { get; set; } = pathId;

	public int Skin { get; set; }

	public int Rank { get; set; }

	public int EquipId { get; set; }

	public Dictionary<int, int> Relic { get; set; } = new Dictionary<int, int>();

	public ItemData? EquipData { get; set; }

	public int EnhanceId { get; set; }

	public Dictionary<int, EnhanceInfo> EnhanceInfos { get; set; } = new Dictionary<int, EnhanceInfo>();

	public Dictionary<int, int> GetSkillTree()
	{
		if (EnhanceInfos.TryGetValue(EnhanceId, out EnhanceInfo value))
		{
			return value.SkillTree;
		}
		EnhanceInfos[EnhanceId] = new EnhanceInfo(EnhanceId);
		AvatarConfigExcel valueOrDefault = GameData.AvatarConfigData.GetValueOrDefault(PathId);
		if (valueOrDefault == null)
		{
			return new Dictionary<int, int>();
		}
		List<AvatarSkillTreeConfigExcel> valueOrDefault2 = valueOrDefault.DefaultSkillTree.GetValueOrDefault(EnhanceId);
		if (valueOrDefault2 == null)
		{
			return new Dictionary<int, int>();
		}
		foreach (AvatarSkillTreeConfigExcel item in valueOrDefault2)
		{
			EnhanceInfos[EnhanceId].SkillTree.Add(item.PointID, item.Level);
		}
		return EnhanceInfos[EnhanceId].SkillTree;
	}
}
