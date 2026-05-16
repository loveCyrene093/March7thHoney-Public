using System;
using March7thHoney.Kcp;
using March7thHoney.Proto;
using March7thHoney.Util;
using March7thHoney.Util.Security;

namespace March7thHoney.GameServer.Server.Packet.Send.Player;

public class PacketPlayerGetTokenScRsp : BasePacket
{
	public PacketPlayerGetTokenScRsp(Connection connection)
		: base(18)
	{
		PlayerGetTokenScRsp playerGetTokenScRsp = new PlayerGetTokenScRsp
		{
			BlackInfo = new BlackInfo(),
			Uid = (uint)(connection.Player?.Uid ?? 0)
		};
		if (ConfigManager.Config.GameServer.UsePacketEncryption)
		{
			MT19937 mT = new MT19937((ulong)DateTimeOffset.Now.ToUnixTimeSeconds());
			playerGetTokenScRsp.SecretKeySeed = (connection.ClientSecretKeySeed = mT.NextUInt64());
		}
		SetData(playerGetTokenScRsp);
	}

	public PacketPlayerGetTokenScRsp(uint uid, Retcode ret, BlackInfo? black = null, string msg = "")
		: base(18)
	{
		PlayerGetTokenScRsp data = new PlayerGetTokenScRsp
		{
			Retcode = (uint)ret,
			BlackInfo = (black ?? new BlackInfo()),
			Uid = uid
		};
		SetData(data);
	}
}
