using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Scene;

public class PacketActivateFarmElementScRsp : BasePacket
{
	public PacketActivateFarmElementScRsp(uint entityId, PlayerInstance player)
		: base(1430)
	{
		ActiveFarmElementScRsp data = new ActiveFarmElementScRsp
		{
			EntityId = entityId,
			WorldLevel = (uint)player.Data.WorldLevel
		};
		SetData(data);
	}
}
