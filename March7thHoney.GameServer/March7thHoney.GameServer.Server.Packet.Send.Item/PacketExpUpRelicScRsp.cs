using System.Collections.Generic;
using March7thHoney.Database.Inventory;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Item;

public class PacketExpUpRelicScRsp : BasePacket
{
	public PacketExpUpRelicScRsp(List<ItemData> leftover)
		: base(538)
	{
		ExpUpRelicScRsp expUpRelicScRsp = new ExpUpRelicScRsp();
		foreach (ItemData item in leftover)
		{
			expUpRelicScRsp.ReturnItemList.Add(item.ToPileProto());
		}
		SetData(expUpRelicScRsp);
	}
}
