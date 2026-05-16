using System.Threading.Tasks;
using March7thHoney.GameServer.Game.GridFight;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.GridFight;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.GridFight;

[Opcode(8800)]
public class HandlerGridFightBackToPrepareReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GridFightBackToPrepareReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		GridFightInstance inst = player.GridFightManager?.GridFightInstance;
		await connection.SendPacket(new PacketGDMIIBNJJEJ());
		if (inst != null)
		{
			uint oldPos = inst.QueuePosition;
			inst.AdvanceQueue();
			inst.PendingAction = new GridFightPendingAction
			{
				QueuePosition = inst.QueuePosition,
				RoundBeginAction = new GridFightRoundBeginActionInfo()
			};
			await connection.SendPacket(new PacketGridFightHandlePendingActionScRsp(inst.QueuePosition));
			await connection.SendPacket(new PacketGridFightSyncUpdateResultScNotify(player, 1, (oldPos, inst.QueuePosition)));
		}
	}
}
