using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Mission;

public class PacketUpdateTrackMainMissionIdScRsp : BasePacket
{
	public PacketUpdateTrackMainMissionIdScRsp(int prev, int cur)
		: base(1279)
	{
		UpdateTrackMainMissionScRsp data = new UpdateTrackMainMissionScRsp
		{
			PrevTrackMissionId = (uint)prev,
			TrackMissionId = (uint)cur
		};
		SetData(data);
	}
}
