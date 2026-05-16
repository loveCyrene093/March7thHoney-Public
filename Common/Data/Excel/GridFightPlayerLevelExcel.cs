using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace March7thHoney.Data.Excel;

[ResourceEntity("GridFightPlayerLevel.json")]
public class GridFightPlayerLevelExcel : ExcelResource
{
	public uint PlayerLevel { get; set; }

	public uint LevelUpExp { get; set; }

	public uint AvatarMaxNumber { get; set; }

	public uint Rarity1Weight { get; set; }

	public uint Rarity2Weight { get; set; }

	public uint Rarity3Weight { get; set; }

	public uint Rarity4Weight { get; set; }

	public uint Rarity5Weight { get; set; }

	[JsonIgnore]
	public List<uint> RarityWeights
	{
		get
		{
			int num = 5;
			List<uint> list = new List<uint>(num);
			CollectionsMarshal.SetCount(list, num);
			Span<uint> span = CollectionsMarshal.AsSpan(list);
			span[0] = Rarity1Weight;
			span[1] = Rarity2Weight;
			span[2] = Rarity3Weight;
			span[3] = Rarity4Weight;
			span[4] = Rarity5Weight;
			return list;
		}
	}

	public override int GetId()
	{
		return (int)PlayerLevel;
	}

	public override void Loaded()
	{
		GameData.GridFightPlayerLevelData.TryAdd(PlayerLevel, this);
	}
}
