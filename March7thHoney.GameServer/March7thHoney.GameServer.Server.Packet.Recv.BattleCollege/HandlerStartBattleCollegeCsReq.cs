using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Battle;
using March7thHoney.GameServer.Server.Packet.Send.BattleCollege;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.BattleCollege;

[Opcode(5795)]
public class HandlerStartBattleCollegeCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		StartBattleCollegeCsReq startBattleCollegeCsReq = StartBattleCollegeCsReq.Parser.ParseFrom(data);
		(Retcode, BattleInstance)? tuple = connection.Player.BattleManager?.StartBattleCollege((int)startBattleCollegeCsReq.Id);
		if (tuple.HasValue)
		{
			await connection.SendPacket(new PacketStartBattleCollegeScRsp(startBattleCollegeCsReq.Id, tuple.Value.Item1, tuple.Value.Item2));
		}
		else
		{
			await connection.SendPacket(new PacketStartBattleCollegeScRsp(startBattleCollegeCsReq.Id, Retcode.RetWaitLogin, null));
		}
	}
}
