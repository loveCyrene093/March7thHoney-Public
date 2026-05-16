using March7thHoney.Database.Inventory;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Item;

public class PacketComposeSelectedRelicScRsp : BasePacket
{
	public PacketComposeSelectedRelicScRsp(uint composeId)
		: base(589)
	{
		ComposeSelectedRelicScRsp data = new ComposeSelectedRelicScRsp
		{
			ComposeId = composeId,
			Retcode = 1u
		};
		SetData(data);
	}

	public PacketComposeSelectedRelicScRsp(uint composeId, Retcode retcode)
		: base(589)
	{
		ComposeSelectedRelicScRsp data = new ComposeSelectedRelicScRsp
		{
			ComposeId = composeId,
			Retcode = (uint)retcode
		};
		SetData(data);
	}

	public PacketComposeSelectedRelicScRsp(uint composeId, ItemData item)
		: base(589)
	{
		ComposeSelectedRelicScRsp data = new ComposeSelectedRelicScRsp
		{
			ReturnItemList = new ItemList
			{
				ItemList_ = { item.ToProto() }
			},
			ComposeId = composeId
		};
		SetData(data);
	}
}
