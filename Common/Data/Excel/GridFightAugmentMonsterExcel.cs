using System.Collections.Generic;
using March7thHoney.Enums.GridFight;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Excel;

[ResourceEntity("GridFightAugmentMonster.json")]
public class GridFightAugmentMonsterExcel : ExcelResource
{
	public uint DivisionLevel { get; set; }

	public uint EnemyDiffLvAdd { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public GridFightAugmentQualityEnum Quality { get; set; }

	public override int GetId()
	{
		return (int)DivisionLevel;
	}

	public override void Loaded()
	{
		GameData.GridFightAugmentMonsterData.TryAdd(DivisionLevel, new Dictionary<GridFightAugmentQualityEnum, GridFightAugmentMonsterExcel>());
		GameData.GridFightAugmentMonsterData[DivisionLevel][Quality] = this;
	}
}
