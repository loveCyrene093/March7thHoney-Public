using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Database.Player;
using March7thHoney.GameServer.Server.Packet.Send.ServerPrefs;

namespace March7thHoney.GameServer.Server.Packet.Recv.ServerPrefs;

[Opcode(6191)]
public class HandlerGetAllServerPrefsDataCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		List<ServerPrefsInfo> infos = connection.Player?.ServerPrefsData?.ServerPrefsDict.Values.ToList() ?? new List<ServerPrefsInfo>();
		await connection.SendPacket(new PacketGetAllServerPrefsDataScRsp(infos));
	}
}
