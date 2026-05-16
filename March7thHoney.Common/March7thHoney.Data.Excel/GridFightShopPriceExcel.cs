using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace March7thHoney.Data.Excel;

[ResourceEntity("GridFightShopPrice.json")]
public class GridFightShopPriceExcel : ExcelResource
{
	public uint Rarity { get; set; }

	public uint BuyGoldStar1 { get; set; }

	public uint BuyGoldStar2 { get; set; }

	public uint BuyGoldStar3 { get; set; }

	public uint BuyGoldStar4 { get; set; }

	public uint SellGoldStar1 { get; set; }

	public uint SellGoldStar2 { get; set; }

	public uint SellGoldStar3 { get; set; }

	public uint SellGoldStar4 { get; set; }

	[JsonIgnore]
	public List<uint> BuyGoldList
	{
		get
		{
			int num = 4;
			List<uint> list = new List<uint>(num);
			CollectionsMarshal.SetCount(list, num);
			Span<uint> span = CollectionsMarshal.AsSpan(list);
			span[0] = BuyGoldStar1;
			span[1] = BuyGoldStar2;
			span[2] = BuyGoldStar3;
			span[3] = BuyGoldStar4;
			return list;
		}
	}

	[JsonIgnore]
	public List<uint> SellGoldList
	{
		get
		{
			int num = 4;
			List<uint> list = new List<uint>(num);
			CollectionsMarshal.SetCount(list, num);
			Span<uint> span = CollectionsMarshal.AsSpan(list);
			span[0] = SellGoldStar1;
			span[1] = SellGoldStar2;
			span[2] = SellGoldStar3;
			span[3] = SellGoldStar4;
			return list;
		}
	}

	public override int GetId()
	{
		return (int)Rarity;
	}

	public override void Loaded()
	{
		GameData.GridFightShopPriceData.TryAdd(Rarity, this);
	}
}
