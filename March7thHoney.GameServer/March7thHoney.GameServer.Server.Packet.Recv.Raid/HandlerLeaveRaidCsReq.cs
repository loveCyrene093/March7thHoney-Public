using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Raid;

[Opcode(2230)]
public class HandlerLeaveRaidCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		PlayerInstance? player = connection.Player;
		LeaveRaidCsReq leaveRaidCsReq = LeaveRaidCsReq.Parser.ParseFrom(data);
		await player.RaidManager.LeaveRaid(leaveRaidCsReq.IsSave);
		await connection.SendPacket(2227);
	}
}
