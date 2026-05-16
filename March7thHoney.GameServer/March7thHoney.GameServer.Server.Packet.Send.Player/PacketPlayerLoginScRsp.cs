using System;
using March7thHoney.Kcp;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Server.Packet.Send.Player;

public class PacketPlayerLoginScRsp : BasePacket
{
	public PacketPlayerLoginScRsp(Connection connection)
		: base(10)
	{
		PlayerLoginScRsp data = new PlayerLoginScRsp
		{
			CurTimezone = (int)TimeZoneInfo.Local.BaseUtcOffset.TotalHours,
			ServerTimestampMs = (ulong)ServerTimeProvider.GetServerUnixMs(),
			BasicInfo = connection.Player?.ToProto(),
			Stamina = (uint)(connection.Player?.Data.Stamina ?? 0)
		};
		SetData(data);
	}
}
