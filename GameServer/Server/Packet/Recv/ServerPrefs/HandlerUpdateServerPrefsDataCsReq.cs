using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.ServerPrefs;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.ServerPrefs;

[Opcode(6114)]
public class HandlerUpdateServerPrefsDataCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		UpdateServerPrefsDataCsReq updateServerPrefsDataCsReq = UpdateServerPrefsDataCsReq.Parser.ParseFrom(data);
		connection.Player?.ServerPrefsData?.SetData((int)updateServerPrefsDataCsReq.ServerPrefs.ServerPrefsId, updateServerPrefsDataCsReq.ServerPrefs.Data.ToBase64());
		await connection.SendPacket(new PacketUpdateServerPrefsDataScRsp(updateServerPrefsDataCsReq.ServerPrefs.ServerPrefsId));
	}
}
