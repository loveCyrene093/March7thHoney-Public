using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Scene;

public class PacketGetEnteredSceneScRsp : BasePacket
{
	public PacketGetEnteredSceneScRsp()
		: base(1446)
	{
		GetEnteredSceneScRsp getEnteredSceneScRsp = new GetEnteredSceneScRsp();
		foreach (MapEntranceExcel value in GameData.MapEntranceData.Values)
		{
			if (value.FinishMainMissionList.Count != 0 || value.FinishMainMissionList.Count != 0)
			{
				EnteredSceneInfo item = new EnteredSceneInfo
				{
					FloorId = (uint)value.FloorID,
					PlaneId = (uint)value.PlaneID
				};
				getEnteredSceneScRsp.EnteredSceneInfoList.Add(item);
			}
		}
		SetData(getEnteredSceneScRsp);
	}
}
