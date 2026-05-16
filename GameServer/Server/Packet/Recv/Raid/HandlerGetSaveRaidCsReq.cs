using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Raid;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Raid;

[Opcode(2236)]
public class HandlerGetSaveRaidCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GetSaveRaidCsReq getSaveRaidCsReq = GetSaveRaidCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketGetSaveRaidScRsp(connection.Player, (int)getSaveRaidCsReq.RaidId, (int)getSaveRaidCsReq.WorldLevel));
	}
}
