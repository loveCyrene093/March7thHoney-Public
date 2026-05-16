using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto.ServerSide;

public static class GridFightDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightDataReflection()
	{
		_003C_003Ey__InlineArray66<string> buffer = default(_003C_003Ey__InlineArray66<string>);
		buffer[0] = "ChNHcmlkRmlnaHREYXRhLnByb3RvIjcKF0dyaWRGaWdodFNob3BSb2xlSXRl";
		buffer[1] = "bVBiEg4KBlJvbGVJZBgBIAEoDRIMCgRUaWVyGAIgASgNIm4KE0dyaWRGaWdo";
		buffer[2] = "dFNob3BJdGVtUGISLAoIUm9sZUl0ZW0YASABKAsyGC5HcmlkRmlnaHRTaG9w";
		buffer[3] = "Um9sZUl0ZW1QYkgAEgwKBENvc3QYAiABKA0SDwoHU29sZE91dBgDIAEoCEIK";
		buffer[4] = "CghJdGVtVHlwZSKBAQoTR3JpZEZpZ2h0U2hvcEluZm9QYhISCgpTaG9wTG9j";
		buffer[5] = "a2VkGAEgASgIEhgKEEZyZWVSZWZyZXNoQ291bnQYAiABKA0SEwoLUmVmcmVz";
		buffer[6] = "aENvc3QYAyABKA0SJwoJU2hvcEl0ZW1zGAQgAygLMhQuR3JpZEZpZ2h0U2hv";
		buffer[7] = "cEl0ZW1QYiKKAQoTR3JpZEZpZ2h0R2FtZUluZm9QYhIQCghVbmlxdWVJZBgB";
		buffer[8] = "IAEoDRISCgpEaXZpc2lvbklkGAIgASgNEhIKCklzT3ZlckxvY2sYAyABKAgS";
		buffer[9] = "DgoGU2Vhc29uGAQgASgNEikKCkNvbXBvbmVudHMYBSADKAsyFS5HcmlkRmln";
		buffer[10] = "aHRDb21wb25lbnRQYiLnAgoUR3JpZEZpZ2h0QmFzaWNJbmZvUGISDwoHQ3Vy";
		buffer[11] = "R29sZBgBIAEoDRIQCghDdXJMZXZlbBgCIAEoDRIQCghMZXZlbEV4cBgDIAEo";
		buffer[12] = "DRIUCgxCdXlMZXZlbENvc3QYBCABKA0SDQoFQ3VySHAYBSABKA0SFAoMTWF4";
		buffer[13] = "QXZhdGFyTnVtGAYgASgNEhAKCENvbWJvTnVtGAcgASgNEhAKCExvY2tUeXBl";
		buffer[14] = "GAggASgNEhIKCkxvY2tSZWFzb24YCSABKA0SEwoLTWF4SW50ZXJlc3QYCiAB";
		buffer[15] = "KA0SFgoOVHJhY2tpbmdUcmFpdHMYCyADKA0SOgoSVHJhY2tpbmdFcXVpcG1l";
		buffer[16] = "bnRzGAwgAygLMh4uR3JpZEZpZ2h0RXF1aXBtZW50VHJhY2tJbmZvUGISEQoJ";
		buffer[17] = "R3VpZGVDb2RlGA0gASgJEhAKCE1heExldmVsGA4gASgNEhkKEU9mZkZpZWxk";
		buffer[18] = "QXZhdGFyTnVtGA8gASgNIlcKHUdyaWRGaWdodEVxdWlwbWVudFRyYWNrSW5m";
		buffer[19] = "b1BiEhAKCFByaW9yaXR5GAEgASgNEg4KBlJvbGVJZBgCIAEoDRIUCgxFcXVp";
		buffer[20] = "cG1lbnRJZHMYAyADKA0i2AEKE0dyaWRGaWdodFJvbGVJbmZvUGISDgoGUm9s";
		buffer[21] = "ZUlkGAEgASgNEgwKBFRpZXIYAiABKA0SCwoDUG9zGAMgASgNEhAKCFVuaXF1";
		buffer[22] = "ZUlkGAQgASgNEjoKC1NhdmVkVmFsdWVzGAUgAygLMiUuR3JpZEZpZ2h0Um9s";
		buffer[23] = "ZUluZm9QYi5TYXZlZFZhbHVlc0VudHJ5EhQKDEVxdWlwbWVudElkcxgGIAMo";
		buffer[24] = "DRoyChBTYXZlZFZhbHVlc0VudHJ5EgsKA2tleRgBIAEoCRINCgV2YWx1ZRgC";
		buffer[25] = "IAEoDToCOAEiWAoSR3JpZEZpZ2h0TnBjSW5mb1BiEg0KBU5wY0lkGAEgASgN";
		buffer[26] = "EgsKA1BvcxgCIAEoDRIQCghVbmlxdWVJZBgDIAEoDRIUCgxFcXVpcG1lbnRJ";
		buffer[27] = "ZHMYBCADKA0idQoUR3JpZEZpZ2h0Rm9yZ2VJbmZvUGISEwoLRm9yZ2VJdGVt";
		buffer[28] = "SWQYASABKA0SCwoDUG9zGAIgASgNEhAKCFVuaXF1ZUlkGAMgASgNEikKBUdv";
		buffer[29] = "b2RzGAQgAygLMhouR3JpZEZpZ2h0Rm9yZ2VHb29kc0luZm9QYiJuChlHcmlk";
		buffer[30] = "RmlnaHRGb3JnZUdvb2RzSW5mb1BiEhAKBkl0ZW1JZBgBIAEoDUgAEjIKCFJv";
		buffer[31] = "bGVJbmZvGAIgASgLMh4uR3JpZEZpZ2h0Rm9yZ2VSb2xlR29vZHNJbmZvUGJI";
		buffer[32] = "AEILCglHb29kc1R5cGUiPQodR3JpZEZpZ2h0Rm9yZ2VSb2xlR29vZHNJbmZv";
		buffer[33] = "UGISDgoGUm9sZUlkGAEgASgNEgwKBFRpZXIYAiABKA0imQEKE0dyaWRGaWdo";
		buffer[34] = "dFRlYW1JbmZvUGISIwoFUm9sZXMYASADKAsyFC5HcmlkRmlnaHRSb2xlSW5m";
		buffer[35] = "b1BiEiEKBE5wY3MYAiADKAsyEy5HcmlkRmlnaHROcGNJbmZvUGISJQoGRm9y";
		buffer[36] = "Z2VzGAMgAygLMhUuR3JpZEZpZ2h0Rm9yZ2VJbmZvUGISEwoLQ3VyVW5pcXVl";
		buffer[37] = "SWQYBCABKA0iOQoSR3JpZEZpZ2h0R2FtZU9yYlBiEhEKCU9yYkl0ZW1JZBgB";
		buffer[38] = "IAEoDRIQCghVbmlxdWVJZBgCIAEoDSI3ChJHcmlkRmlnaHRPcmJJbmZvUGIS";
		buffer[39] = "IQoET3JicxgBIAMoCzITLkdyaWRGaWdodEdhbWVPcmJQYiKeAQoWR3JpZEZp";
		buffer[40] = "Z2h0R2FtZUF1Z21lbnRQYhIRCglBdWdtZW50SWQYASABKA0SPQoLU2F2ZWRW";
		buffer[41] = "YWx1ZXMYAiADKAsyKC5HcmlkRmlnaHRHYW1lQXVnbWVudFBiLlNhdmVkVmFs";
		buffer[42] = "dWVzRW50cnkaMgoQU2F2ZWRWYWx1ZXNFbnRyeRILCgNrZXkYASABKAkSDQoF";
		buffer[43] = "dmFsdWUYAiABKA06AjgBIkMKFkdyaWRGaWdodEF1Z21lbnRJbmZvUGISKQoI";
		buffer[44] = "QXVnbWVudHMYASADKAsyFy5HcmlkRmlnaHRHYW1lQXVnbWVudFBiIn8KGkdy";
		buffer[45] = "aWRGaWdodEdhbWVUcmFpdEVmZmVjdFBiEg8KB1RyYWl0SWQYASABKA0SEAoI";
		buffer[46] = "RWZmZWN0SWQYAiABKA0SEwoJVGhyZXNob2xkGAMgASgNSAASGgoQQ29yZVJv";
		buffer[47] = "bGVVbmlxdWVJZBgEIAEoDUgAQg0KC0VmZmVjdFBhcmFtImkKFEdyaWRGaWdo";
		buffer[48] = "dEdhbWVUcmFpdFBiEg8KB1RyYWl0SWQYASABKA0SLAoHRWZmZWN0cxgCIAMo";
		buffer[49] = "CzIbLkdyaWRGaWdodEdhbWVUcmFpdEVmZmVjdFBiEhIKClRyYWl0TGF5ZXIY";
		buffer[50] = "AyABKA0iPQoUR3JpZEZpZ2h0VHJhaXRJbmZvUGISJQoGVHJhaXRzGAEgAygL";
		buffer[51] = "MhUuR3JpZEZpZ2h0R2FtZVRyYWl0UGIiPAoYR3JpZEZpZ2h0RXF1aXBtZW50";
		buffer[52] = "SXRlbVBiEg4KBkl0ZW1JZBgBIAEoDRIQCghVbmlxdWVJZBgCIAEoDSI6ChlH";
		buffer[53] = "cmlkRmlnaHRDb25zdW1hYmxlSXRlbVBiEg4KBkl0ZW1JZBgBIAEoDRINCgVD";
		buffer[54] = "b3VudBgCIAEoDSJ+ChRHcmlkRmlnaHRJdGVtc0luZm9QYhIxCg5FcXVpcG1l";
		buffer[55] = "bnRJdGVtcxgBIAMoCzIZLkdyaWRGaWdodEVxdWlwbWVudEl0ZW1QYhIzCg9D";
		buffer[56] = "b25zdW1hYmxlSXRlbXMYAiADKAsyGi5HcmlkRmlnaHRDb25zdW1hYmxlSXRl";
		buffer[57] = "bVBiItcCChRHcmlkRmlnaHRDb21wb25lbnRQYhIoCghTaG9wSW5mbxgBIAEo";
		buffer[58] = "CzIULkdyaWRGaWdodFNob3BJbmZvUGJIABIqCglCYXNpY0luZm8YAiABKAsy";
		buffer[59] = "FS5HcmlkRmlnaHRCYXNpY0luZm9QYkgAEigKCFRlYW1JbmZvGAMgASgLMhQu";
		buffer[60] = "R3JpZEZpZ2h0VGVhbUluZm9QYkgAEiYKB09yYkluZm8YBCABKAsyEy5Hcmlk";
		buffer[61] = "RmlnaHRPcmJJbmZvUGJIABIuCgtBdWdtZW50SW5mbxgFIAEoCzIXLkdyaWRG";
		buffer[62] = "aWdodEF1Z21lbnRJbmZvUGJIABIqCglUcmFpdEluZm8YBiABKAsyFS5Hcmlk";
		buffer[63] = "RmlnaHRUcmFpdEluZm9QYkgAEioKCUl0ZW1zSW5mbxgHIAEoCzIVLkdyaWRG";
		buffer[64] = "aWdodEl0ZW1zSW5mb1BiSABCDwoNQ29tcG9uZW50VHlwZUIpqgImRWdnTGlu";
		buffer[65] = "ay5EYW5oZW5nU2VydmVyLlByb3RvLlNlcnZlclNpZGViBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[23]
		{
			new GeneratedClrTypeInfo(typeof(GridFightShopRoleItemPb), GridFightShopRoleItemPb.Parser, new string[2] { "RoleId", "Tier" }, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(GridFightShopItemPb), GridFightShopItemPb.Parser, new string[3] { "RoleItem", "Cost", "SoldOut" }, new string[1] { "ItemType" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(GridFightShopInfoPb), GridFightShopInfoPb.Parser, new string[4] { "ShopLocked", "FreeRefreshCount", "RefreshCost", "ShopItems" }, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(GridFightGameInfoPb), GridFightGameInfoPb.Parser, new string[5] { "UniqueId", "DivisionId", "IsOverLock", "Season", "Components" }, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(GridFightBasicInfoPb), GridFightBasicInfoPb.Parser, new string[15]
			{
				"CurGold", "CurLevel", "LevelExp", "BuyLevelCost", "CurHp", "MaxAvatarNum", "ComboNum", "LockType", "LockReason", "MaxInterest",
				"TrackingTraits", "TrackingEquipments", "GuideCode", "MaxLevel", "OffFieldAvatarNum"
			}, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(GridFightEquipmentTrackInfoPb), GridFightEquipmentTrackInfoPb.Parser, new string[3] { "Priority", "RoleId", "EquipmentIds" }, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(GridFightRoleInfoPb), GridFightRoleInfoPb.Parser, new string[6] { "RoleId", "Tier", "Pos", "UniqueId", "SavedValues", "EquipmentIds" }, null, null, null, new GeneratedClrTypeInfo[1]),
			new GeneratedClrTypeInfo(typeof(GridFightNpcInfoPb), GridFightNpcInfoPb.Parser, new string[4] { "NpcId", "Pos", "UniqueId", "EquipmentIds" }, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(GridFightForgeInfoPb), GridFightForgeInfoPb.Parser, new string[4] { "ForgeItemId", "Pos", "UniqueId", "Goods" }, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(GridFightForgeGoodsInfoPb), GridFightForgeGoodsInfoPb.Parser, new string[2] { "ItemId", "RoleInfo" }, new string[1] { "GoodsType" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(GridFightForgeRoleGoodsInfoPb), GridFightForgeRoleGoodsInfoPb.Parser, new string[2] { "RoleId", "Tier" }, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(GridFightTeamInfoPb), GridFightTeamInfoPb.Parser, new string[4] { "Roles", "Npcs", "Forges", "CurUniqueId" }, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(GridFightGameOrbPb), GridFightGameOrbPb.Parser, new string[2] { "OrbItemId", "UniqueId" }, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(GridFightOrbInfoPb), GridFightOrbInfoPb.Parser, new string[1] { "Orbs" }, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(GridFightGameAugmentPb), GridFightGameAugmentPb.Parser, new string[2] { "AugmentId", "SavedValues" }, null, null, null, new GeneratedClrTypeInfo[1]),
			new GeneratedClrTypeInfo(typeof(GridFightAugmentInfoPb), GridFightAugmentInfoPb.Parser, new string[1] { "Augments" }, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(GridFightGameTraitEffectPb), GridFightGameTraitEffectPb.Parser, new string[4] { "TraitId", "EffectId", "Threshold", "CoreRoleUniqueId" }, new string[1] { "EffectParam" }, null, null, null),
			new GeneratedClrTypeInfo(typeof(GridFightGameTraitPb), GridFightGameTraitPb.Parser, new string[3] { "TraitId", "Effects", "TraitLayer" }, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(GridFightTraitInfoPb), GridFightTraitInfoPb.Parser, new string[1] { "Traits" }, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(GridFightEquipmentItemPb), GridFightEquipmentItemPb.Parser, new string[2] { "ItemId", "UniqueId" }, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(GridFightConsumableItemPb), GridFightConsumableItemPb.Parser, new string[2] { "ItemId", "Count" }, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(GridFightItemsInfoPb), GridFightItemsInfoPb.Parser, new string[2] { "EquipmentItems", "ConsumableItems" }, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(GridFightComponentPb), GridFightComponentPb.Parser, new string[7] { "ShopInfo", "BasicInfo", "TeamInfo", "OrbInfo", "AugmentInfo", "TraitInfo", "ItemsInfo" }, new string[1] { "ComponentType" }, null, null, null)
		}));
	}
}
