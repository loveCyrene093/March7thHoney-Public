using System.Collections.Generic;

namespace March7thHoney.Data.Excel;

[ResourceEntity("GridFightRoleBasicInfo.json")]
public class GridFightRoleBasicInfoExcel : ExcelResource
{
	public uint ID { get; set; }

	public uint SpecialAvatarID { get; set; }

	public uint AvatarID { get; set; }

	public uint SeasonID { get; set; }

	public uint Rarity { get; set; }

	public string FrontBackType { get; set; } = "Front";

	public uint EquipmentID { get; set; }

	public List<uint> TraitList { get; set; } = new List<uint>();

	public List<string> RoleSavedValueList { get; set; } = new List<string>();

	public bool IsInPool { get; set; }

	public override int GetId()
	{
		return (int)ID;
	}

	public override void Loaded()
	{
		GameData.GridFightRoleBasicInfoData.TryAdd(ID, this);
	}
}
