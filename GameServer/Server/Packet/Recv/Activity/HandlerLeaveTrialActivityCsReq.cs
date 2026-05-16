using System.Threading.Tasks;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Activity;

[Opcode(2606)]
public class HandlerLeaveTrialActivityCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		LeaveTrialActivityCsReq.Parser.ParseFrom(data);
		if (connection.Player.ActivityManager.TrialActivityInstance != null)
		{
			await connection.Player.ActivityManager.TrialActivityInstance.EndActivity();
		}
		connection.Player.ActivityManager.TrialActivityInstance = null;
		await connection.SendPacket(2688);
	}
}
