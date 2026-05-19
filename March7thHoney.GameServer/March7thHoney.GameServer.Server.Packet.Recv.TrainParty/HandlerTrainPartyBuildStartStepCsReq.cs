using System.Threading.Tasks;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.TrainParty;

[Opcode(8074)]
public class HandlerTrainPartyBuildStartStepCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		TrainPartyBuildStartStepCsReq trainPartyBuildStartStepCsReq = TrainPartyBuildStartStepCsReq.Parser.ParseFrom(data);
		uint curFund;
		uint retcode = connection.Player.TrainPartyManager.BuildStartStep(trainPartyBuildStartStepCsReq.AreaId, trainPartyBuildStartStepCsReq.FNLNPLHOEJN, trainPartyBuildStartStepCsReq.LMHIBHGINLG, out curFund);
		BasePacket basePacket = new BasePacket(8037);
		basePacket.SetData(new TrainPartyBuildStartStepScRsp
		{
			CurFund = curFund,
			Retcode = retcode
		});
		await connection.SendPacket(basePacket);
	}
}
