using System.Collections.Generic;
using System.Linq;
using March7thHoney.Database.Inventory;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Item;

public class PacketExpUpEquipmentScRsp : BasePacket
{
	public PacketExpUpEquipmentScRsp(List<ItemData> returnItem)
		: base(501)
	{
		ExpUpEquipmentScRsp expUpEquipmentScRsp = new ExpUpEquipmentScRsp();
		expUpEquipmentScRsp.ReturnItemList.AddRange(returnItem.Select((ItemData item) => item.ToPileProto()));
		SetData(expUpEquipmentScRsp);
	}
}
