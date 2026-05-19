using System;
using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Inventory;

namespace March7thHoney.Database.Avatar;

public class PathInfo
{
	public int PathId { get; set; }

	public int Skin { get; set; }

	public int Rank { get; set; }

	public int EquipId { get; set; }

	public Dictionary<int, int> Relic { get; set; }

	public ItemData? EquipData { get; set; }

	public int EnhanceId { get; set; }

	public Dictionary<int, EnhanceInfo> EnhanceInfos { get; set; }

	public PathInfo(int pathId)
	{
		PathId = pathId;
		Relic = new Dictionary<int, int>();
		EnhanceInfos = new Dictionary<int, EnhanceInfo>();
		base._002Ector();
	}

	public Dictionary<int, int> GetSkillTree()
	{
		if (EnhanceInfos.TryGetValue(EnhanceId, out EnhanceInfo value))
		{
			NormalizePointIdsForEnhanceId(value);
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

	private void NormalizePointIdsForEnhanceId(EnhanceInfo enhance)
	{
		if (!GameData.AvatarConfigData.TryGetValue(PathId, out AvatarConfigExcel value))
		{
			return;
		}
		List<AvatarSkillTreeConfigExcel> valueOrDefault = value.SkillTree.GetValueOrDefault(EnhanceId);
		if (valueOrDefault == null || valueOrDefault.Count == 0)
		{
			return;
		}
		List<KeyValuePair<int, int>> list = enhance.SkillTree.Where((KeyValuePair<int, int> kv) => GameData.AvatarSkillTreeConfigData.TryGetValue(kv.Key * 100 + 1, out AvatarSkillTreeConfigExcel value4) && value4.EnhancedID != EnhanceId).ToList();
		if (list.Count == 0)
		{
			return;
		}
		foreach (KeyValuePair<int, int> item in list)
		{
			item.Deconstruct(out var key, out var value2);
			int num = key;
			int val = value2;
			enhance.SkillTree.Remove(num);
			if (!GameData.AvatarSkillTreeConfigData.TryGetValue(num * 100 + 1, out AvatarSkillTreeConfigExcel value3))
			{
				continue;
			}
			int slot = value3.GetMultiPointId();
			if (slot > 0)
			{
				AvatarSkillTreeConfigExcel avatarSkillTreeConfigExcel = valueOrDefault.Find((AvatarSkillTreeConfigExcel a) => a.GetMultiPointId() == slot);
				if (avatarSkillTreeConfigExcel != null)
				{
					enhance.SkillTree[avatarSkillTreeConfigExcel.PointID] = Math.Min(val, avatarSkillTreeConfigExcel.MaxLevel);
				}
			}
		}
	}
}
