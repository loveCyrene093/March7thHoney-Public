using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Friend;

public class PacketGetPlayerDetailInfoScRsp : BasePacket
{
	public PacketGetPlayerDetailInfoScRsp(PlayerDetailInfo info)
		: base(2995)
	{
		GetPlayerDetailInfoScRsp data = new GetPlayerDetailInfoScRsp
		{
			DetailInfo = info
		};
		SetData(data);
	}

	public PacketGetPlayerDetailInfoScRsp()
		: base(2995)
	{
		GetPlayerDetailInfoScRsp data = new GetPlayerDetailInfoScRsp
		{
			Retcode = 3612u
		};
		SetData(data);
	}
}
