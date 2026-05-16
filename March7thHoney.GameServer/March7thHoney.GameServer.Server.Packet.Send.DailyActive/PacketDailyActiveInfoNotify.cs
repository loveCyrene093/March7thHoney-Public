using March7thHoney.GameServer.Game.DailyActive;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.DailyActive;

public class PacketDailyActiveInfoNotify : BasePacket
{
	public PacketDailyActiveInfoNotify()
		: base(3314)
	{
		DailyActiveInfoNotify dailyActiveInfoNotify = new DailyActiveInfoNotify
		{
			DailyActivePoint = 500u
		};
		dailyActiveInfoNotify.DailyActiveLevelList.AddRange(DailyActiveDefaults.CreateLevels(isHasTaken: true));
		dailyActiveInfoNotify.DailyActiveQuestIdList.AddRange(DailyActiveDefaults.QuestIds);
		SetData(dailyActiveInfoNotify);
	}
}
