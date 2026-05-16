using March7thHoney.Database.Scene;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Raid;

public class PacketStartRaidScRsp : BasePacket
{
	public PacketStartRaidScRsp(RaidRecord record, PlayerInstance player)
		: base(2207)
	{
		StartRaidScRsp data = new StartRaidScRsp();
		SetData(data);
	}

	public PacketStartRaidScRsp(Retcode ret)
		: base(2207)
	{
		StartRaidScRsp data = new StartRaidScRsp
		{
			Retcode = (uint)ret
		};
		SetData(data);
	}
}
