using System.Collections.Generic;
using SqlSugar;

namespace March7thHoney.Database.Inventory;

[SugarTable("offering_data")]
public class OfferingData : BaseDatabaseDataHelper
{
	[SugarColumn(IsJson = true, ColumnDataType = "TEXT")]
	public Dictionary<int, OfferingTypeData> Offerings { get; set; } = new Dictionary<int, OfferingTypeData>();
}
