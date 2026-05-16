using System.Threading.Tasks;
using March7thHoney.GameServer.Game.GridFight;
using March7thHoney.GameServer.Game.GridFight.PendingAction;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.GridFight;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.GridFight;

[Opcode(8407)]
public class HandlerGridFightSelectRecommendEquipCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GridFightSelectRecommendEquipCsReq gridFightSelectRecommendEquipCsReq = GridFightSelectRecommendEquipCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		GridFightInstance gridFightInstance = player.GridFightManager?.GridFightInstance;
		if (gridFightInstance == null)
		{
			await connection.SendPacket(new PacketGridFightHandlePendingActionScRsp(gridFightSelectRecommendEquipCsReq.QueuePosition));
			await connection.SendPacket(new PacketGridFightSyncUpdateResultScNotify(player));
		}
		else
		{
			await GridFightPendingActionProcessor.Handle(connection, gridFightInstance, gridFightSelectRecommendEquipCsReq);
		}
	}
}
