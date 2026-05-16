using System.Threading.Tasks;
using March7thHoney.Database.Inventory;
using March7thHoney.GameServer.Server.Packet.Send.Offering;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Offering;

[Opcode(6922)]
public class HandlerSubmitOfferingItemCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SubmitOfferingItemCsReq submitOfferingItemCsReq = SubmitOfferingItemCsReq.Parser.ParseFrom(data);
		(Retcode, OfferingTypeData) tuple = await connection.Player.OfferingManager.SubmitOfferingItem((int)submitOfferingItemCsReq.OfferingId);
		await connection.SendPacket(new PacketSubmitOfferingItemScRsp(tuple.Item1, tuple.Item2));
	}
}
