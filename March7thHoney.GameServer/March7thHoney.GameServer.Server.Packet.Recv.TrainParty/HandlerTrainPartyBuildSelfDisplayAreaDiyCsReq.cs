using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.TrainParty;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.TrainParty;

[Opcode(8066)]
public class HandlerTrainPartyBuildSelfDisplayAreaDiyCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		TrainPartyBuildSelfDisplayAreaDiyCsReq trainPartyBuildSelfDisplayAreaDiyCsReq = TrainPartyBuildSelfDisplayAreaDiyCsReq.Parser.ParseFrom(data);
		PlayerInstance? player = connection.Player;
		KJGMAEGNBKL selfDisplay = player.TrainPartyManager.SetSelfDisplay(trainPartyBuildSelfDisplayAreaDiyCsReq.ICJFLLDCFHM);
		await player.SendPacket(new PacketTrainPartyBuildSelfDisplayAreaDiyScRsp(selfDisplay));
	}
}
