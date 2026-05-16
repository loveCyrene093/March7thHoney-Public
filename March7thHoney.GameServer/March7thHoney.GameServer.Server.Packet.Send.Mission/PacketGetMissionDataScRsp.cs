using System.Linq;
using March7thHoney.Data;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Mission;

public class PacketGetMissionDataScRsp : BasePacket
{
	public PacketGetMissionDataScRsp(PlayerInstance player)
		: base(1210)
	{
		GetMissionDataScRsp getMissionDataScRsp = new GetMissionDataScRsp
		{
			TrackMissionId = (uint)player.MissionManager.Data.TrackingMainMissionId
		};
		foreach (int key in GameData.MainMissionData.Keys)
		{
			if (player.MissionManager.GetMainMissionStatus(key) == MissionPhaseEnum.Accept)
			{
				getMissionDataScRsp.MainMissionList.Add(new MainMission
				{
					Id = (uint)key,
					Status = MissionStatus.MissionDoing
				});
			}
		}
		foreach (int item in GameData.SubMissionInfoData.Keys.Concat(GameData.SubMissionData.Keys))
		{
			if (player.MissionManager.GetSubMissionStatus(item) == MissionPhaseEnum.Accept)
			{
				getMissionDataScRsp.MissionList.Add(new March7thHoney.Proto.Mission
				{
					Id = (uint)item,
					Status = MissionStatus.MissionDoing,
					Progress = (uint)player.MissionManager.GetMissionProgress(item)
				});
			}
		}
		SetData(getMissionDataScRsp);
	}
}
