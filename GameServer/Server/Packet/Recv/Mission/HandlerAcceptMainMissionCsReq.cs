using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Mission;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Mission;

[Opcode(1273)]
public class HandlerAcceptMainMissionCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		AcceptMainMissionCsReq acceptMainMissionCsReq = AcceptMainMissionCsReq.Parser.ParseFrom(data);
		uint missionId = acceptMainMissionCsReq.MainMissionId;
		await connection.Player.MissionManager.AcceptMainMission((int)missionId);
		await connection.SendPacket(new PacketAcceptMainMissionScRsp(missionId));
	}
}
