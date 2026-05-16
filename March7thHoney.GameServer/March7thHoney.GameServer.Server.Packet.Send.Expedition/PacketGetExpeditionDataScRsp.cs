using March7thHoney.GameServer.Game.Expedition;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Expedition;

public class PacketGetExpeditionDataScRsp : BasePacket
{
	public PacketGetExpeditionDataScRsp(PlayerInstance player)
		: base(2507)
	{
		ExpeditionManager expeditionManager = player.ExpeditionManager;
		GetExpeditionDataScRsp getExpeditionDataScRsp = new GetExpeditionDataScRsp
		{
			KAMBBFDEBAM = expeditionManager.GetRefreshTime(),
			TotalExpeditionCount = expeditionManager.GetTotalExpeditionCount()
		};
		getExpeditionDataScRsp.NBKFAEDOGPG.Add(expeditionManager.GetAllExpeditionIds());
		getExpeditionDataScRsp.ExpeditionInfo.Add(expeditionManager.GetActiveExpeditionInfo());
		SetData(getExpeditionDataScRsp);
	}
}
