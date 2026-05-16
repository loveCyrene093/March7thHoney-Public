using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Mission;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Mission;

[Opcode(1254)]
public class HandlerUpdateTrackMainMissionIdCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		UpdateTrackMainMissionCsReq updateTrackMainMissionCsReq = UpdateTrackMainMissionCsReq.Parser.ParseFrom(data);
		int trackingMainMissionId = connection.Player.MissionManager.Data.TrackingMainMissionId;
		connection.Player.MissionManager.Data.TrackingMainMissionId = (int)updateTrackMainMissionCsReq.TrackMissionId;
		await connection.SendPacket(new PacketUpdateTrackMainMissionIdScRsp(trackingMainMissionId, connection.Player.MissionManager.Data.TrackingMainMissionId));
	}
}
