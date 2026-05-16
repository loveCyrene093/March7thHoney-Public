using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;

namespace March7thHoney.GameServer.Server.Packet.Send.DiceCombat;

public class PacketGetDiceCombatSystemDataScRsp : BasePacket
{
	public PacketGetDiceCombatSystemDataScRsp(PlayerInstance player)
		: base(9275)
	{
		SetData(player.ActivityManager.DiceCombat.BuildSystemDataPayload());
	}
}
