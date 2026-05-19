using System.Threading.Tasks;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.TrainParty;

[Opcode(8030)]
public class HandlerTrainPartySetBadgeAutoFillCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		TrainPartySetBadgeAutoFillCsReq trainPartySetBadgeAutoFillCsReq = TrainPartySetBadgeAutoFillCsReq.Parser.ParseFrom(data);
		uint retcode = connection.Player.TrainPartyManager.SetBadgeAutoFill(trainPartySetBadgeAutoFillCsReq.AELMBPLDFGJ);
		BasePacket basePacket = new BasePacket(8071);
		basePacket.SetData(new TrainPartySetBadgeAutoFillScRsp
		{
			AELMBPLDFGJ = trainPartySetBadgeAutoFillCsReq.AELMBPLDFGJ,
			Retcode = retcode
		});
		await connection.SendPacket(basePacket);
	}
}
