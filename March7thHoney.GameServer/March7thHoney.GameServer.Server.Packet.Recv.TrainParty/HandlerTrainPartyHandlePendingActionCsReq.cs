using System.Threading.Tasks;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.TrainParty;

[Opcode(8039)]
public class HandlerTrainPartyHandlePendingActionCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		TrainPartyHandlePendingActionCsReq trainPartyHandlePendingActionCsReq = TrainPartyHandlePendingActionCsReq.Parser.ParseFrom(data);
		TrainPartyHandlePendingActionScRsp rsp;
		uint retcode = connection.Player.TrainPartyManager.HandlePendingAction(trainPartyHandlePendingActionCsReq.QueuePosition, out rsp);
		rsp.Retcode = retcode;
		BasePacket basePacket = new BasePacket(8001);
		basePacket.SetData(rsp);
		await connection.SendPacket(basePacket);
	}
}
