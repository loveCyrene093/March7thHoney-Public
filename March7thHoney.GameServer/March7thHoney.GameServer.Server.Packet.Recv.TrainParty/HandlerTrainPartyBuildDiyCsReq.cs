using System.Threading.Tasks;
using March7thHoney.Database.TrainParty;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.TrainParty;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.TrainParty;

[Opcode(8004)]
public class HandlerTrainPartyBuildDiyCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		TrainPartyBuildDiyCsReq trainPartyBuildDiyCsReq = TrainPartyBuildDiyCsReq.Parser.ParseFrom(data);
		PlayerInstance? player = connection.Player;
		TrainAreaInfo area = player.TrainPartyManager.SetDynamicId((int)trainPartyBuildDiyCsReq.AreaId, (int)trainPartyBuildDiyCsReq.DiceSlotId, (int)trainPartyBuildDiyCsReq.DiyDynamicId);
		await player.SendPacket(new PacketTrainPartyBuildDiyScRsp(area));
	}
}
