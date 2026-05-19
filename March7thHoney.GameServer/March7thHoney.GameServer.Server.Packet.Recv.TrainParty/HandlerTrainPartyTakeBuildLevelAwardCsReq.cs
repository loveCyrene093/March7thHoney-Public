using System.Threading.Tasks;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.TrainParty;

[Opcode(8008)]
public class HandlerTrainPartyTakeBuildLevelAwardCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		TrainPartyTakeBuildLevelAwardCsReq trainPartyTakeBuildLevelAwardCsReq = TrainPartyTakeBuildLevelAwardCsReq.Parser.ParseFrom(data);
		ItemList itemList;
		uint retcode = connection.Player.TrainPartyManager.TakeBuildLevelAward(trainPartyTakeBuildLevelAwardCsReq.HBLOHOFKKKO, out itemList);
		BasePacket basePacket = new BasePacket(8017);
		basePacket.SetData(new TrainPartyTakeBuildLevelAwardScRsp
		{
			HBLOHOFKKKO = trainPartyTakeBuildLevelAwardCsReq.HBLOHOFKKKO,
			ItemList = itemList,
			Retcode = retcode
		});
		await connection.SendPacket(basePacket);
	}
}
