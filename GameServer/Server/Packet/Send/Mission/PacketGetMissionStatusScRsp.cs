using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Mission;

public class PacketGetMissionStatusScRsp : BasePacket
{
	public PacketGetMissionStatusScRsp(GetMissionStatusCsReq req, PlayerInstance player)
		: base(1207)
	{
		GetMissionStatusScRsp getMissionStatusScRsp = new GetMissionStatusScRsp();
		foreach (uint mainMissionId in req.MainMissionIdList)
		{
			if (player.MissionManager.GetMainMissionStatus((int)mainMissionId) == MissionPhaseEnum.Finish)
			{
				getMissionStatusScRsp.FinishedMainMissionIdList.Add(mainMissionId);
			}
			else
			{
				getMissionStatusScRsp.UnfinishedMainMissionIdList.Add(mainMissionId);
			}
		}
		foreach (uint subMissionId in req.SubMissionIdList)
		{
			MissionPhaseEnum subMissionStatus = player.MissionManager.GetSubMissionStatus((int)subMissionId);
			getMissionStatusScRsp.SubMissionStatusList.Add(new March7thHoney.Proto.Mission
			{
				Id = subMissionId,
				Status = subMissionStatus.ToProto()
			});
		}
		SetData(getMissionStatusScRsp);
	}
}
