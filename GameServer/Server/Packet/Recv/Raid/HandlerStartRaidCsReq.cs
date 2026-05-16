using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Database.Scene;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Raid;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Raid;

[Opcode(2213)]
public class HandlerStartRaidCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		StartRaidCsReq startRaidCsReq = StartRaidCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		RaidRecord raidRecord = await player.RaidManager.EnterRaid((int)startRaidCsReq.RaidId, (int)startRaidCsReq.WorldLevel, startRaidCsReq.AvatarList.Select((uint x) => (int)x).ToList(), startRaidCsReq.IsSave == 1);
		if (raidRecord == null)
		{
			await connection.SendPacket(new PacketStartRaidScRsp(Retcode.RetReqParaInvalid));
		}
		else
		{
			await connection.SendPacket(new PacketStartRaidScRsp(raidRecord, player));
		}
	}
}
