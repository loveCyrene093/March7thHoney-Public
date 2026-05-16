using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Activity;
using March7thHoney.GameServer.Game.Activity.Activities;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Activity;

[Opcode(2677)]
public class HandlerStartTrialActivityCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		StartTrialActivityCsReq startTrialActivityCsReq = StartTrialActivityCsReq.Parser.ParseFrom(data);
		ActivityManager? activityManager = connection.Player.ActivityManager;
		activityManager.TrialActivityInstance = new TrialActivityInstance(activityManager);
		await activityManager.TrialActivityInstance.StartActivity((int)startTrialActivityCsReq.StageId);
	}
}
