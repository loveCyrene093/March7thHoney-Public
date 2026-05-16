using March7thHoney.Kcp;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Server.Packet.Send.Battle;

public class PacketGetFarmStageGachaInfoScRsp : BasePacket
{
	public PacketGetFarmStageGachaInfoScRsp(GetFarmStageGachaInfoCsReq req)
		: base(1395)
	{
		GetFarmStageGachaInfoScRsp getFarmStageGachaInfoScRsp = new GetFarmStageGachaInfoScRsp();
		foreach (uint farmStageGachaId in req.FarmStageGachaIdList)
		{
			getFarmStageGachaInfoScRsp.FarmStageGachaInfoList.Add(new FarmStageGachaInfo
			{
				GachaId = farmStageGachaId,
				BeginTime = 0L,
				EndTime = Extensions.GetUnixSec() + 3600
			});
		}
		SetData(getFarmStageGachaInfoScRsp);
	}
}
