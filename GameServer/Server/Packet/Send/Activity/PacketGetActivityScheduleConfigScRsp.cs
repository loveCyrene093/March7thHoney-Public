using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Activity;

public class PacketGetActivityScheduleConfigScRsp : BasePacket
{
	public PacketGetActivityScheduleConfigScRsp(PlayerInstance player)
		: base(2618)
	{
		GetActivityScheduleConfigScRsp getActivityScheduleConfigScRsp = new GetActivityScheduleConfigScRsp();
		getActivityScheduleConfigScRsp.ScheduleData.AddRange(player.ActivityManager.ToProto());
		SetData(getActivityScheduleConfigScRsp);
	}
}
