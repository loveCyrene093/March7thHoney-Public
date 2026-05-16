using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Player;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Player;

[Opcode(35)]
public class HandlerUpdatePlayerSettingCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		UpdatePlayerSettingCsReq updatePlayerSettingCsReq = UpdatePlayerSettingCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketUpdatePlayerSettingScRsp(updatePlayerSettingCsReq.PlayerSetting));
	}
}
