using System.Collections.Generic;
using System.Linq;
using March7thHoney.Database.Inventory;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Offering;

public class PacketTakeOfferingRewardScRsp : BasePacket
{
	public PacketTakeOfferingRewardScRsp(Retcode ret, OfferingTypeData? data, List<ItemData> reward)
		: base(6928)
	{
		TakeOfferingRewardScRsp takeOfferingRewardScRsp = new TakeOfferingRewardScRsp
		{
			Retcode = (uint)ret
		};
		if (data != null)
		{
			takeOfferingRewardScRsp.OfferingInfo = data.ToProto();
			takeOfferingRewardScRsp.Reward = new ItemList
			{
				ItemList_ = { reward.Select((ItemData x) => x.ToProto()) }
			};
		}
		SetData(takeOfferingRewardScRsp);
	}
}
