using System.Collections.Generic;
using March7thHoney.Enums.Item;
using March7thHoney.Util;
using Newtonsoft.Json;

namespace March7thHoney.Data.Excel;

[ResourceEntity("ItemConfig.json,ItemConfigAvatar.json,ItemConfigAvatarLD.json,ItemConfigAvatarPlayerIcon.json,ItemConfigAvatarPlayerIcLD.json,ItemConfigAvatarRank.json,ItemConfigAvatarRankLD.json,ItemConfigBook.json,ItemConfigDisk.json,ItemConfigEquipment.json,ItemConfigRelic.json,ItemPlayerCard.json,ItemConfigTrainDynamic.json,ItemConfigAvatarSkin.json", true)]
public class ItemConfigExcel : ExcelResource
{
	public int ID { get; set; }

	public HashName ItemName { get; set; } = new HashName();

	[JsonConverter(typeof(SafeStringEnumConverter<ItemMainTypeEnum>))]
	public ItemMainTypeEnum ItemMainType { get; set; }

	[JsonConverter(typeof(SafeStringEnumConverter<ItemSubTypeEnum>))]
	public ItemSubTypeEnum ItemSubType { get; set; }

	[JsonConverter(typeof(SafeStringEnumConverter<ItemRarityEnum>))]
	public ItemRarityEnum Rarity { get; set; }

	public int PileLimit { get; set; }

	public int PurposeType { get; set; }

	public int UseDataID { get; set; }

	[JsonConverter(typeof(SafeStringEnumConverter<ItemUseMethodEnum>))]
	public ItemUseMethodEnum UseMethod { get; set; }

	public List<MappingInfoItem> ReturnItemIDList { get; set; } = new List<MappingInfoItem>();

	[JsonIgnore]
	public int Exp { get; set; }

	[JsonIgnore]
	public string? Name { get; set; }

	public override int GetId()
	{
		return ID;
	}

	public override void Loaded()
	{
		GameData.ItemConfigData[ID] = this;
	}
}
