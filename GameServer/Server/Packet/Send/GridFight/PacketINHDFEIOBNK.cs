using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.GridFight;

public class PacketINHDFEIOBNK : BasePacket
{
	public PacketINHDFEIOBNK(PlayerInstance player)
		: base(8540)
	{
		INHDFEIOBNK data = new INHDFEIOBNK
		{
			FightCurrentInfo = player.GridFightManager.BuildCurrentInfo()
		};
		SetData(data);
	}
}
