using System.Collections.Generic;
using System.Linq;

namespace March7thHoney.Data.Excel;

[ResourceEntity("AvatarSkillTreeConfig.json,AvatarSkillTreeConfigLD.json", true)]
public class AvatarSkillTreeConfigExcel : ExcelResource
{
	public int PointID { get; set; }

	public int Level { get; set; }

	public int AvatarID { get; set; }

	public string AnchorType { get; set; } = "";

	public int EnhancedID { get; set; }

	public bool DefaultUnlock { get; set; }

	public int MaxLevel { get; set; }

	public int GetMultiPointId()
	{
		if (string.IsNullOrWhiteSpace(AnchorType))
		{
			return 0;
		}
		int num = 0;
		int num2 = 1;
		for (int num3 = AnchorType.Length - 1; num3 >= 0; num3--)
		{
			char c = AnchorType[num3];
			if ((c < '0' || c > '9') ? true : false)
			{
				break;
			}
			num += (c - 48) * num2;
			num2 *= 10;
		}
		return num;
	}

	public override int GetId()
	{
		return PointID * 100 + Level;
	}

	public override void AfterAllDone()
	{
		GameData.AvatarConfigData.TryGetValue(AvatarID, out AvatarConfigExcel value);
		GameData.AvatarSkillTreeConfigData.TryAdd(GetId(), this);
		if (value != null)
		{
			value.DefaultSkillTree.TryAdd(EnhancedID, new List<AvatarSkillTreeConfigExcel>());
			value.SkillTree.TryAdd(EnhancedID, new List<AvatarSkillTreeConfigExcel>());
			if (DefaultUnlock && value.DefaultSkillTree[EnhancedID].All((AvatarSkillTreeConfigExcel x) => x.PointID != PointID))
			{
				value.DefaultSkillTree[EnhancedID].Add(this);
			}
			if (value.SkillTree[EnhancedID].All((AvatarSkillTreeConfigExcel x) => x.PointID != PointID))
			{
				value.SkillTree[EnhancedID].Add(this);
			}
		}
	}
}
