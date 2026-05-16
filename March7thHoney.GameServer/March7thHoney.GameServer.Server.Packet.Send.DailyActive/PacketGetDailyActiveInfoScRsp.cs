using March7thHoney.GameServer.Game.DailyActive;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.DailyActive;

public class PacketGetDailyActiveInfoScRsp : BasePacket
{
	public PacketGetDailyActiveInfoScRsp()
		: base(3395)
	{
		GetDailyActiveInfoScRsp getDailyActiveInfoScRsp = new GetDailyActiveInfoScRsp
		{
			DailyActivePoint = 500u
		};
		getDailyActiveInfoScRsp.DailyActiveLevelList.AddRange(DailyActiveDefaults.CreateLevels(isHasTaken: true));
		getDailyActiveInfoScRsp.DailyActiveQuestIdList.AddRange(DailyActiveDefaults.QuestIds);
		SetData(getDailyActiveInfoScRsp);
	}
}
