using System.Collections.Generic;
using March7thHoney.Database.Inventory;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Item;

public class PacketUseItemScRsp : BasePacket
{
	public PacketUseItemScRsp(Retcode retCode, uint itemId, uint count, List<ItemData>? returnItems)
		: base(598)
	{
		UseItemScRsp useItemScRsp = new UseItemScRsp
		{
			Retcode = (uint)retCode,
			UseItemId = itemId,
			UseItemCount = count
		};
		if (returnItems != null)
		{
			useItemScRsp.ReturnData = new ItemList();
			foreach (ItemData returnItem in returnItems)
			{
				useItemScRsp.ReturnData.ItemList_.Add(returnItem.ToProto());
			}
		}
		SetData(useItemScRsp);
	}
}
