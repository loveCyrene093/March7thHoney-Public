using Google.Protobuf;
using March7thHoney.Database.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.ServerPrefs;

public class PacketGetServerPrefsDataScRsp : BasePacket
{
	public PacketGetServerPrefsDataScRsp(ServerPrefsInfo? info, uint id)
		: base(6195)
	{
		GetServerPrefsDataScRsp data = new GetServerPrefsDataScRsp
		{
			ServerPrefs = (info?.ToProto() ?? new March7thHoney.Proto.ServerPrefs
			{
				Data = ByteString.Empty,
				ServerPrefsId = id
			})
		};
		SetData(data);
	}
}
