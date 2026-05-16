using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Database.Inventory;
using March7thHoney.GameServer.Server.Packet.Send.Offering;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Offering;

[Opcode(6935)]
public class HandlerTakeOfferingRewardCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		TakeOfferingRewardCsReq takeOfferingRewardCsReq = TakeOfferingRewardCsReq.Parser.ParseFrom(data);
		(Retcode, OfferingTypeData, List<ItemData>) tuple = await connection.Player.OfferingManager.TakeOfferingReward((int)takeOfferingRewardCsReq.OfferingId, takeOfferingRewardCsReq.TakeRewardLevelList.Select((uint x) => (int)x).ToList());
		await connection.SendPacket(new PacketTakeOfferingRewardScRsp(tuple.Item1, tuple.Item2, tuple.Item3));
	}
}
