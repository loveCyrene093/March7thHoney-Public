using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.GameServer.Game.GridFight;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.GridFight;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.GridFight;

[Opcode(8405)]
public class HandlerGridFightUpdatePosCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GridFightUpdatePosCsReq gridFightUpdatePosCsReq = GridFightUpdatePosCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		GridFightService gridFightService = new GridFightService(player);
		if (gridFightService.Current == null)
		{
			await connection.SendPacket(new PacketGridFightUpdatePosScRsp());
			return;
		}
		List<GridFightPosInfo> posList = gridFightService.UpdatePos(gridFightUpdatePosCsReq.GridFightPosInfoList);
		await connection.SendPacket(new PacketGridFightUpdatePosScRsp(posList));
		await connection.SendPacket(new PacketGridFightSyncUpdateResultScNotify(player, posList));
	}
}
