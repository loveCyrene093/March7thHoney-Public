using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.ServerPrefs;

public class PacketUpdateServerPrefsDataScRsp : BasePacket
{
	public PacketUpdateServerPrefsDataScRsp(uint prefsId)
		: base(6118)
	{
		UpdateServerPrefsDataScRsp data = new UpdateServerPrefsDataScRsp
		{
			ServerPrefsId = prefsId
		};
		SetData(data);
	}
}
