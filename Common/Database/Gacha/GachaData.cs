using System.Collections.Generic;
using SqlSugar;

namespace March7thHoney.Database.Gacha;

[SugarTable("Gacha")]
public class GachaData : BaseDatabaseDataHelper
{
	[SugarColumn(IsJson = true)]
	public List<GachaInfo> GachaHistory { get; set; } = new List<GachaInfo>();

	public bool LastAvatarGachaFailed { get; set; }

	public bool LastWeaponGachaFailed { get; set; }

	public int LastGachaFailedCount { get; set; }

	public int LastGachaPurpleFailedCount { get; set; }

	[SugarColumn(IsJson = true)]
	public List<int> GachaDecideOrder { get; set; } = new List<int>();
}
