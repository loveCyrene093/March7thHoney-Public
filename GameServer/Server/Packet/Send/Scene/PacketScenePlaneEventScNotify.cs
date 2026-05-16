using System.Collections.Generic;
using System.Runtime.InteropServices;
using March7thHoney.Database.Inventory;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Scene;

public class PacketScenePlaneEventScNotify : BasePacket
{
	public PacketScenePlaneEventScNotify(ItemData item)
	{
		int num = 1;
		List<ItemData> list = new List<ItemData>(num);
		CollectionsMarshal.SetCount(list, num);
		CollectionsMarshal.AsSpan(list)[0] = item;
		this._002Ector(list);
	}

	public PacketScenePlaneEventScNotify(List<ItemData> itemDatas)
		: base(1482)
	{
		ItemList itemList = new ItemList();
		foreach (ItemData itemData in itemDatas)
		{
			itemList.ItemList_.Add(itemData.ToProto());
		}
		ScenePlaneEventScNotify data = new ScenePlaneEventScNotify
		{
			GetItemList = itemList
		};
		SetData(data);
	}

	public PacketScenePlaneEventScNotify(ItemList list)
		: base(1482)
	{
		ScenePlaneEventScNotify data = new ScenePlaneEventScNotify
		{
			GetItemList = list
		};
		SetData(data);
	}
}
