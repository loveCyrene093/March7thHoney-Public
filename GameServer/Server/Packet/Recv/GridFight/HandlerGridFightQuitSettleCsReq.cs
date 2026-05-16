using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.GridFight;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.GridFight;

[Opcode(8480)]
public class HandlerGridFightQuitSettleCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GridFightQuitSettleCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		uint keepWinCnt = (player.GridFightManager?.GridFightInstance?.KeepWinCnt).GetValueOrDefault();
		await connection.SendPacket(new PacketGridFightWeeklyExtraSeasonExpScRsp());
		await connection.SendPacket(new PacketGridFightSyncKeepWinCntNotify(keepWinCnt));
		await connection.SendPacket(new PacketGridFightSettleNotify(player));
		player.GridFightManager.GridFightInstance = null;
		BasePacket basePacket = new BasePacket(8755);
		basePacket.SetData(new GCOBEPOGHPL());
		await connection.SendPacket(basePacket);
	}
}
