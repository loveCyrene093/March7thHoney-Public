using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Database.Inventory;
using March7thHoney.GameServer.Server.Packet.Send.Offering;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Offering;

[Opcode(6921)]
public class HandlerGetOfferingInfoCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GetOfferingInfoCsReq getOfferingInfoCsReq = GetOfferingInfoCsReq.Parser.ParseFrom(data);
		List<OfferingTypeData> list = new List<OfferingTypeData>();
		list.AddRange(getOfferingInfoCsReq.OfferingIdList.Select((uint id) => connection.Player.OfferingManager.GetOfferingData((int)id)).OfType<OfferingTypeData>());
		await connection.SendPacket(new PacketGetOfferingInfoScRsp(list));
	}
}
