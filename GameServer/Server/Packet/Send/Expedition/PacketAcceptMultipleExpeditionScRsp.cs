using System.Collections.Generic;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Expedition;

public class PacketAcceptMultipleExpeditionScRsp : BasePacket
{
	public PacketAcceptMultipleExpeditionScRsp(PlayerInstance player, IEnumerable<ExpeditionInfo> accepted)
		: base(2550)
	{
		AcceptMultipleExpeditionScRsp acceptMultipleExpeditionScRsp = new AcceptMultipleExpeditionScRsp
		{
			KAMBBFDEBAM = player.ExpeditionManager.GetRefreshTime()
		};
		acceptMultipleExpeditionScRsp.AcceptMultiExpedition.Add(accepted);
		SetData(acceptMultipleExpeditionScRsp);
	}
}
