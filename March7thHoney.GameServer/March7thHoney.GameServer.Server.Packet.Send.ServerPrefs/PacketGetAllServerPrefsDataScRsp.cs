using System.Collections.Generic;
using March7thHoney.Database.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.ServerPrefs;

public class PacketGetAllServerPrefsDataScRsp : BasePacket
{
	public PacketGetAllServerPrefsDataScRsp(List<ServerPrefsInfo> infos)
		: base(6110)
	{
		GetAllServerPrefsDataScRsp getAllServerPrefsDataScRsp = new GetAllServerPrefsDataScRsp();
		foreach (ServerPrefsInfo info in infos)
		{
			getAllServerPrefsDataScRsp.ServerPrefsList.Add(info.ToProto());
		}
		SetData(getAllServerPrefsDataScRsp);
	}
}
