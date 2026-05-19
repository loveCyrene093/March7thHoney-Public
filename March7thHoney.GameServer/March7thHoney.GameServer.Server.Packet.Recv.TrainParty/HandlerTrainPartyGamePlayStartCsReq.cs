using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.TrainParty;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.TrainParty;

[Opcode(8057)]
public class HandlerTrainPartyGamePlayStartCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		TrainPartyGamePlayStartCsReq trainPartyGamePlayStartCsReq = TrainPartyGamePlayStartCsReq.Parser.ParseFrom(data);
		FKPMOKOJNHP gameplayData;
		uint retcode = connection.Player.TrainPartyManager.StartGameplay(trainPartyGamePlayStartCsReq.DMMNCNGGPHL, trainPartyGamePlayStartCsReq.MAONLHBKOFK, out gameplayData);
		BasePacket basePacket = new BasePacket(8021);
		basePacket.SetData(new TrainPartyGamePlayStartScRsp
		{
			MLBJFOPPBCM = gameplayData,
			Retcode = retcode
		});
		await connection.SendPacket(basePacket);
		await connection.SendPacket(new PacketTrainPartyMoveScNotify(connection.Player));
	}
}
