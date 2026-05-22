using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum ItemType
{
	[OriginalName("ITEM_TYPE_NONE")]
	None,
	[OriginalName("ITEM_AVATAR_CARD")]
	ItemAvatarCard,
	[OriginalName("ITEM_EQUIPMENT")]
	ItemEquipment,
	[OriginalName("ITEM_MATERIAL")]
	ItemMaterial,
	[OriginalName("ITEM_AVATAR_EXP")]
	ItemAvatarExp,
	[OriginalName("ITEM_RELIC")]
	ItemRelic
}
