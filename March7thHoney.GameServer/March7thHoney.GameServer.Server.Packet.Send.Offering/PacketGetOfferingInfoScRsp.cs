using System.Collections.Generic;
using System.Linq;
using March7thHoney.Database.Inventory;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Offering;

public class PacketGetOfferingInfoScRsp : BasePacket
{
	public PacketGetOfferingInfoScRsp(List<OfferingTypeData> dataList)
		: base(6940)
	{
		GetOfferingInfoScRsp data = new GetOfferingInfoScRsp
		{
			OfferingInfoList = { (IEnumerable<OfferingInfo>)dataList.Select((OfferingTypeData offeringTypeData) => offeringTypeData.ToProto()).ToList() }
		};
		SetData(data);
	}
}
