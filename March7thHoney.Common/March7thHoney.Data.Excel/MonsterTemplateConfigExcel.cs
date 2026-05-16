using System.Collections.Generic;

namespace March7thHoney.Data.Excel;

[ResourceEntity("MonsterTemplateConfig.json")]
public class MonsterTemplateConfigExcel : ExcelResource
{
	public int MonsterTemplateID { get; set; }

	public List<int> NPCMonsterList { get; set; } = new List<int>();

	public int MonsterCampID { get; set; }

	public override int GetId()
	{
		return MonsterTemplateID;
	}

	public override void Loaded()
	{
		GameData.MonsterTemplateConfigData.Add(MonsterTemplateID, this);
	}
}
