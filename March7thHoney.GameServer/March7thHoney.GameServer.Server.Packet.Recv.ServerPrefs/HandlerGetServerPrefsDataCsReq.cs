using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.Database.Player;
using March7thHoney.GameServer.Server.Packet.Send.ServerPrefs;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.ServerPrefs;

[Opcode(6194)]
public class HandlerGetServerPrefsDataCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GetServerPrefsDataCsReq getServerPrefsDataCsReq = GetServerPrefsDataCsReq.Parser.ParseFrom(data);
		ServerPrefsInfo info = connection.Player.ServerPrefsData?.ServerPrefsDict.GetValueOrDefault((int)getServerPrefsDataCsReq.ServerPrefsId);
		await connection.SendPacket(new PacketGetServerPrefsDataScRsp(info, getServerPrefsDataCsReq.ServerPrefsId));
	}
}
