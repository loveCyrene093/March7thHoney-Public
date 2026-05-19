using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.TrainParty;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.TrainParty;

[Opcode(8094)]
public class HandlerTrainPartyUseCardCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		TrainPartyUseCardCsReq trainPartyUseCardCsReq = TrainPartyUseCardCsReq.Parser.ParseFrom(data);
		uint retcode = connection.Player.TrainPartyManager.UseCard(trainPartyUseCardCsReq.GDFPBHMMFEA);
		BasePacket basePacket = new BasePacket(8095);
		basePacket.SetData(new TrainPartyUseCardScRsp
		{
			GDFPBHMMFEA = trainPartyUseCardCsReq.GDFPBHMMFEA,
			Retcode = retcode
		});
		await connection.SendPacket(basePacket);
		await connection.SendPacket(new PacketTrainPartySettleNotify(connection.Player));
	}
}
