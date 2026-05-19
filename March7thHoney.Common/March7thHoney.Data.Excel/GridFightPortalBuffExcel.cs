using System.Collections.Generic;
using March7thHoney.Data.Config;

namespace March7thHoney.Data.Excel;

[ResourceEntity("GridFightPortalBuff.json")]
public class GridFightPortalBuffExcel : ExcelResource
{
	public uint ID { get; set; }

	public bool IfInBook { get; set; }

	public List<FixedValueInfo<uint>> EffectParamList { get; set; } = new List<FixedValueInfo<uint>>();

	public List<uint> ShowBonusIDList { get; set; } = new List<uint>();

	public List<uint> PortalGameRefTrait { get; set; } = new List<uint>();

	public override int GetId()
	{
		return (int)ID;
	}

	public override void Loaded()
	{
		GameData.GridFightPortalBuffData.TryAdd(ID, this);
	}
}
