using March7thHoney.Database.Inventory;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Item;

public class PacketComposeItemScRsp : BasePacket
{
	public PacketComposeItemScRsp()
		: base(537)
	{
		ComposeItemScRsp data = new ComposeItemScRsp
		{
			Retcode = 1u
		};
		SetData(data);
	}

	public PacketComposeItemScRsp(uint composeId, uint count, ItemData item)
		: base(537)
	{
		ComposeItemScRsp data = new ComposeItemScRsp
		{
			ReturnItemList = new ItemList
			{
				ItemList_ = { item.ToProto() }
			},
			ComposeId = composeId,
			Count = count
		};
		SetData(data);
	}
}
