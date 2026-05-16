using System.Collections.Generic;
using March7thHoney.Proto;
using Newtonsoft.Json;

namespace March7thHoney.Data.Excel;

[ResourceEntity("ShopGoodsConfig.json")]
public class ShopGoodsConfigExcel : ExcelResource
{
	public int GoodsID { get; set; }

	public int ShopID { get; set; }

	public int ItemID { get; set; }

	public int ItemCount { get; set; }

	public List<int> CurrencyList { get; set; } = new List<int>();

	public List<int> CurrencyCostList { get; set; } = new List<int>();

	[JsonIgnore]
	public Dictionary<int, int> CostList { get; set; } = new Dictionary<int, int>();

	public override int GetId()
	{
		return GoodsID;
	}

	public override void Loaded()
	{
		for (int i = 0; i < CurrencyList.Count; i++)
		{
			CostList.Add(CurrencyList[i], CurrencyCostList[i]);
		}
	}

	public override void AfterAllDone()
	{
		GameData.ShopConfigData[ShopID].Goods.Add(this);
	}

	public Goods ToProto()
	{
		return new Goods
		{
			EndTime = 4294967295L,
			GoodsId = (uint)GoodsID,
			ItemId = (uint)ItemID
		};
	}
}
