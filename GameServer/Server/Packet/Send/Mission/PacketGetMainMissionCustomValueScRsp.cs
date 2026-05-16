using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Mission;

public class PacketGetMainMissionCustomValueScRsp : BasePacket
{
	public PacketGetMainMissionCustomValueScRsp(GetMainMissionCustomValueCsReq req, PlayerInstance player)
		: base(1217)
	{
		GetMainMissionCustomValueScRsp getMainMissionCustomValueScRsp = new GetMainMissionCustomValueScRsp();
		foreach (uint mainMissionId in req.MainMissionIdList)
		{
			getMainMissionCustomValueScRsp.MainMissionList.Add(new MainMission
			{
				Id = mainMissionId,
				Status = player.MissionManager.GetMainMissionStatus((int)mainMissionId).ToProto()
			});
		}
		SetData(getMainMissionCustomValueScRsp);
	}
}
